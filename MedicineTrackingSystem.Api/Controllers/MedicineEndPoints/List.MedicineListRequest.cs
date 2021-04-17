using MedicineTrackingSystem.Core.Filters;
using Microsoft.AspNetCore.Mvc;

namespace MedicineTrackingSystem.Api.Controllers.MedicineEndPoints
{
    public class MedicineListRequest
    {
        [FromQuery(Name = "searchTerm")]
        public string SeachTerm { get; set; }

        public static MedicineFilterDto MapToFilter(MedicineListRequest req)
        {
            return new MedicineFilterDto
            {
                SearchTerm = req.SeachTerm
            };
        }
    }
}
