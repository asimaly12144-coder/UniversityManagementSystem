using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class InstituteController : BaseController
    {
        private readonly InstituteServices _instituteServices;
        public InstituteController(InstituteServices instituteServices)
        {
            _instituteServices = instituteServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllInstitutes()
        {
            return new JsonResult(new { success = true, data = _instituteServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] InstituteRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _instituteServices.AddInstitute(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteInstitute")]
        public IActionResult Delete([FromForm] InstituteRequestDTO request)
        {
            bool result = _instituteServices.RemoveInstitute(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Institute not found"
            });
        }
    }
}
