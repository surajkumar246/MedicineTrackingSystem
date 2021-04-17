using MedicineTrackingSystem.Core.Dtos;
using MedicineTrackingSystem.Core.Entities;
using MedicineTrackingSystem.Core.Filters;
using MedicineTrackingSystem.Core.Interfaces;
using System.Collections.Generic;

namespace MedicineTrackingSystem.Core.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly IMedicineRepository medicineRepository;
        public MedicineService(IMedicineRepository medicineRepository)
        {
            this.medicineRepository = medicineRepository;
        }
        public MedicineDto Add(Medicine modal)
        {
            return medicineRepository.Add(modal);
        }

        public IEnumerable<MedicineDto> GetAll(MedicineFilterDto filter)
        {
            return medicineRepository.GetAll(filter);
        }

        public MedicineDto GetById(int medicineId)
        {
            return medicineRepository.GetById(medicineId);
        }

        public bool Remove(Medicine modal)
        {
            return medicineRepository.Remove(modal);
        }
    }
}
