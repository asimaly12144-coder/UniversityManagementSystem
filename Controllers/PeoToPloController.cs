using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class PeoToPloController : BaseController
    {
        private readonly PeoToPloServices _peoToPloServices;
        public PeoToPloController(PeoToPloServices peoToPloServices)
        {
            _peoToPloServices = peoToPloServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllPeoToPlos()
        {
            return new JsonResult(new { success = true, data = _peoToPloServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] PeoToPloRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _peoToPloServices.AddPeoToPlo(request), message = "Created Successfully" });
        }
        [HttpPost("DeletePeoToPlo")]
        public IActionResult Delete([FromForm] PeoToPloRequestDTO request)
        {
            bool result = _peoToPloServices.RemovePeoToPlo(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "PEO to PLO mapping not found"
            });
        }
    }
}
