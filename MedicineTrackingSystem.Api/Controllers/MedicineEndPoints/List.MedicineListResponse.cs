using MedicineTrackingSystem.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicineTrackingSystem.Api.Controllers.MedicineEndPoints
{
    public class MedicineListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Color { get; set; }
        public static IEnumerable<MedicineListResponse> MapToResponse(IEnumerable<MedicineDto> items)
        {
            return items.Select(_ => new MedicineListResponse
            {
                Id = _.Id,
                Brand = _.Brand,
                Color = _.Color,
                ExpiryDate = _.ExpiryDate,
                Name = _.Name,
                Price = _.Price,
                Quantity = _.Quantity,
            });
        }
    }
}
