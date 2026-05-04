using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;

namespace UniversityManagmentSystem.Controllers
{
    public class FacultyCampusController : BaseController
    {
        private readonly FacultyCampusServices _facultyCampusServices;

        public FacultyCampusServices FacultyCampusServices => _facultyCampusServices;

        public FacultyCampusController(FacultyCampusServices facultyCampusServices)
        {
            _facultyCampusServices = facultyCampusServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllFacultyCampuses()
        {
            return new JsonResult(new { success = true, data = FacultyCampusServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] FacultyCampusRequestDTO request)
        {
            return new JsonResult(new { success = true, data = FacultyCampusServices.AddFacultyCampus(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteFacultyCampus")]
        public IActionResult Delete([FromForm] FacultyCampusRequestDTO request)
        {
            bool result = FacultyCampusServices.RemoveFacultyCampus(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Faculty Campus not found"
            });
        }
    }
}
