using Microsoft.AspNetCore.Mvc;

namespace MedicineTrackingSystem.Api.Controllers.MedicineEndPoints
{
    public class MedicineGetRequest
    {
        [FromRoute(Name = "id")]
        public int Id { get; set; }
    }
}
