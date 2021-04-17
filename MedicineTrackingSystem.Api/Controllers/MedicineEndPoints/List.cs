using MedicineTrackingSystem.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MedicineTrackingSystem.Api.Controllers.MedicineEndPoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/medicines")]
    public class List : ControllerBase
    {
        private readonly IMedicineService medicineService;
        public List(IMedicineService medicineService)
        {
            this.medicineService = medicineService;
        }

        [HttpGet]
        public IEnumerable<MedicineListResponse> Handle([FromQuery]MedicineListRequest request)
        {
            var filter = MedicineListRequest.MapToFilter(request);
            var res = medicineService.GetAll(filter);
            return MedicineListResponse.MapToResponse(res);
        }
    }
}
