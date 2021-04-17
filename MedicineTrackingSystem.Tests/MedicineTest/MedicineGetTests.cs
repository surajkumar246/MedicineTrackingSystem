using MedicineTrackingSystem.Core.Entities;
using MedicineTrackingSystem.Core.Filters;
using MedicineTrackingSystem.Core.Services;
using MedicineTrackingSystem.Infrastructure.Data;
using MedicineTrackingSystem.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
namespace MedicineTrackingSystem.Tests.MedicineTest
{
    public class MedicineGetTests
    {
        [Fact]
        public void Should_Get_AllTheItemsInStore()
        {
            // arrange
            var filter = new MedicineFilterDto();
            var result = new List<Medicine>
            {
                new Medicine
            {
                Id = 1,
                Brand = "GSK",
                Name = "ABC",
                Notes = "No side  Efficts observed ",
                Price = 1,
                ExpiryDate = DateTime.UtcNow.AddDays(10),
                Quantity = 30,
            },
                new Medicine
            {
                Id = 2,
                Brand = "BP",
                Name = "DEF",
                Notes = "some side  Efficts observed ",
                Price = 2,
                ExpiryDate = DateTime.UtcNow.AddYears(1),
                Quantity = 5,
            },
            };
            var context = new MedicineContext();
            context.Medicines = result;
            var repo = new MedicineRepository(context);
            var service = new MedicineService(repo);


            // act

            var acutal = service.GetAll(filter);
            var expected = result;

            // Assert
            Assert.Equal(expected.Count(), acutal.Count());
        }

        [Fact]
        public void Should_Get_ItemsWithSearchTerm()
        {
            // arrange
            var filter = new MedicineFilterDto
            {
                SearchTerm = "AB",
            };
            var item = new Medicine
            {
                Id = 1,
                Brand = "GSK",
                Name = "ABC",
                Notes = "No side  Efficts observed ",
                Price = 1,
                ExpiryDate = DateTime.UtcNow.AddDays(10),
                Quantity = 30,
            };
            var result = new List<Medicine>
            {
               item,
               new Medicine
            {
                Id = 2,
                Brand = "BP",
                Name = "DEF",
                Notes = "some side  Efficts observed ",
                Price = 2,
                ExpiryDate = DateTime.UtcNow.AddYears(1),
                Quantity = 5,
            },
            };
            var context = new MedicineContext();
            context.Medicines = result;
            var repo = new MedicineRepository(context);
            var service = new MedicineService(repo);


            // act
            var returnedVal = service.GetAll(filter);
            var actual = returnedVal.FirstOrDefault();
            var expected = item.Id;

            // Assert
            Assert.Equal(expected, actual.Id);
            Assert.Single(returnedVal);
        }
    }
}
