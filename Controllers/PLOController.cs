using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class PLOController : BaseController
    {
        private readonly PloServices _ploServices;
        public PLOController(PloServices ploServices)
        {
            _ploServices = ploServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllPLOs()
        {
            return new JsonResult(new { success = true, data = _ploServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] PloRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _ploServices.AddPlo(request), message = "Created Successfully" });
        }
        [HttpPost("DeletePLO")]
        public IActionResult Delete([FromForm] PloRequestDTO request)
        {
            bool result = _ploServices.RemovePlo(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "PLO not found"
            });
        }
    }
}
