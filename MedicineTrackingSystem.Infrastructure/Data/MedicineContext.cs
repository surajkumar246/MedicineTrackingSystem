using MedicineTrackingSystem.Core.Entities;
using System;
using System.Collections.Generic;

namespace MedicineTrackingSystem.Infrastructure.Data
{
    public class MedicineContext
    {
        public List<Medicine> Medicines = new List<Medicine>
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
            new Medicine
            {
                Id = 3,
                Brand = "Glaxo",
                Name = "GHI",
                Notes = "Severe side  Efficts observed ",
                Price = 3,
                ExpiryDate = DateTime.UtcNow.AddYears(1),
                Quantity = 3,
            },
            new Medicine
            {
                Id = 4,
                Brand = "Dabur",
                Name = "JKL",
                Notes = "No side  Efficts observed for this medicine ",
                Price = 5,
                ExpiryDate = DateTime.UtcNow.AddYears(1),
                Quantity = 30,
            },
            new Medicine
            {
                Id = 5,
                Brand = "Pfizer",
                Name = "Remdesivir",
                Notes = "No major side  Efficts observed ",
                Price = 50,
                ExpiryDate = DateTime.UtcNow.AddYears(1),
                Quantity = 30,
            },

        };
    }
}
