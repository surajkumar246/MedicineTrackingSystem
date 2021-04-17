using MedicineTrackingSystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedicineTrackingSystem.Api.Controllers.MedicineEndPoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/medicines")]
    public class Get : ControllerBase
    {
        private readonly IMedicineService medicineService;
        public Get(IMedicineService medicineService)
        {
            this.medicineService = medicineService;
        }

        [HttpGet("{id}")]
        public MedicineGetResponse Handle(MedicineGetRequest request)
        {
            var res = medicineService.GetById(request.Id);
            return MedicineGetResponse.MapToResponse(res);

        }
    }
}
