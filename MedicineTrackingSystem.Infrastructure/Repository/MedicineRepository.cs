using MedicineTrackingSystem.Core.Dtos;
using MedicineTrackingSystem.Core.Entities;
using MedicineTrackingSystem.Core.Enums;
using MedicineTrackingSystem.Core.Filters;
using MedicineTrackingSystem.Core.Interfaces;
using MedicineTrackingSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicineTrackingSystem.Infrastructure.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly MedicineContext medicineContext;
        public MedicineRepository(MedicineContext context = null)
        {
            this.medicineContext = context ?? new MedicineContext();
        }
        public MedicineDto Add(Medicine modal)
        {
            medicineContext.Medicines.Add(modal);
            return new MedicineDto
            {
                Id = modal.Id,
                Brand = modal.Brand,
                Color = GetColor(modal),
                ExpiryDate = modal.ExpiryDate,
                Quantity = modal.Quantity,
                Name = modal.Name,
                Notes = modal.Notes,
                Price = modal.Price,
            };
        }

        public IEnumerable<MedicineDto> GetAll(MedicineFilterDto filter)
        {
            var result =  medicineContext.Medicines.Select(_ => new MedicineDto
                    {
                        Id = _.Id,
                        Brand = _.Brand,
                        Color = GetColor(_),
                        ExpiryDate = _.ExpiryDate,
                        Quantity = _.Quantity,
                        Name = _.Name,
                        Notes = _.Notes,
                        Price = _.Price,
                    });
            if (!string.IsNullOrWhiteSpace(filter.SearchTerm))
            {
                return result.Where(_ => _.Name.ToLower().Contains(filter.SearchTerm.ToLower()));
            }
            return result;
        }

        public MedicineDto GetById(int medicineId)
        {
            return medicineContext.Medicines.Where(_ => _.Id == medicineId)
                .Select(_ => new MedicineDto
                {
                    Id = _.Id,
                    Brand = _.Brand,
                    Color = GetColor(_),
                    ExpiryDate = _.ExpiryDate,
                    Quantity = _.Quantity,
                    Name = _.Name,
                    Notes = _.Notes,
                    Price = _.Price,
                })
                .FirstOrDefault();
        }

        public bool Remove(Medicine modal)
        {
            var med = GetById(modal.Id);
            medicineContext.Medicines.Remove(modal);
            return true;
        }

        private static string GetColor(Medicine modal)
        {
            return modal.Quantity < 10 ? ColorType.YELLOW : DateTime.Compare(modal.ExpiryDate, DateTime.UtcNow.AddDays(30)) < 0 ? ColorType.RED : null;
        }
    }
}
