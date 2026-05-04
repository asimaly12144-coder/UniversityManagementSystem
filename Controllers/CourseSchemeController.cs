using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;

namespace UniversityManagmentSystem.Controllers
{
    public class CourseSchemeController : BaseController
    {
        private readonly CourseSchemeServices _courseSchemeServices;
        public CourseSchemeController(CourseSchemeServices courseSchemeServices)
        {
            _courseSchemeServices = courseSchemeServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllCourseSchemes()
        {
            return new JsonResult(new { success = true, data = _courseSchemeServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] CourseSchemeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _courseSchemeServices.Add(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteCourseScheme")]
        public IActionResult Delete([FromBody] CourseSchemeRequestDTO request)
        {
            bool result = _courseSchemeServices.Remove(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Course Scheme not found"
            });
        }
    }
}
