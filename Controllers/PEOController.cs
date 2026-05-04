using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class PEOController : BaseController
    {
        private readonly PeoServices _peoServices;
        public PEOController(PeoServices peoServices)
        {
            _peoServices = peoServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllPEOs()
        {
            return new JsonResult(new { success = true, data = _peoServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] DTOs.RequestDTO.PeoRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _peoServices.AddPeo(request), message = "Created Successfully" });
        }
        [HttpPost("DeletePEO")]
        public IActionResult Delete([FromForm] DTOs.RequestDTO.PeoRequestDTO request)
        {
            bool result = _peoServices.RemovePeo(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "PEO not found"
            });
        }
    }
}
