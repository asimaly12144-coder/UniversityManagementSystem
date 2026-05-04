using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class FacultyController : BaseController
    {
        private readonly FacultyService _facultyService;
        public FacultyController(FacultyService facultyService)
        {
            _facultyService = facultyService;
        }

        [HttpPost("Faculty")]
        public ActionResult Post([FromForm] FacultyRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _facultyService.AddService(request), message = "Created Successfully" });
        }

        //Get
        [HttpGet("Faculty")]
        public ActionResult GetAll()
        {
            return new JsonResult(new { success = true, data = _facultyService.GetAll(), message = "Fetched Successfully" });
        }
        //Delete
        [HttpDelete("Faculty/{id}")]
        public ActionResult Delete([FromForm] FacultyRequestDTO request)        {

            return new JsonResult(new { success = true, data = _facultyService.RemoveFaculty(request.Id), message = "Deleted Successfully" });
        }
    }
}
