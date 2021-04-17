using MedicineTrackingSystem.Core.Dtos;
using System;

namespace MedicineTrackingSystem.Api.Controllers.MedicineEndPoints
{
    public class MedicineGetResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Notes { get; set; }
        public string Color { get; set; }

        public static MedicineGetResponse MapToResponse(MedicineDto modal)
        {
            return new MedicineGetResponse
            {
                Id = modal.Id,
                Brand = modal.Brand,
                Color = modal.Color,
                ExpiryDate = modal.ExpiryDate,
                Name = modal.Name,
                Notes = modal.Notes,
                Price = modal.Price,
                Quantity = modal.Quantity,
            };
        }
    }
}
