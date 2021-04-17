using MedicineTrackingSystem.Core.Dtos;
using MedicineTrackingSystem.Core.Entities;
using MedicineTrackingSystem.Core.Filters;
using System.Collections.Generic;

namespace MedicineTrackingSystem.Core.Interfaces
{
    public interface IMedicineService
    {
        public IEnumerable<MedicineDto> GetAll(MedicineFilterDto filter);
        public MedicineDto GetById(int medicineId);
        public MedicineDto Add(Medicine modal);
        public bool Remove(Medicine modal);
    }
}
