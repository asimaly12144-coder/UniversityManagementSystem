using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class SemesterController : BaseController
    {
        private readonly SemesterService _semesterService;
        public SemesterController(SemesterService semesterService)
        {
            _semesterService = semesterService;
        }
        [HttpPost("Semester")]
        public ActionResult Post([FromForm] SemesterRequestDTO request)
        {
            var result = _semesterService.AddSemster(request);
            return new JsonResult(new { success = true, data = result, message = "Semester Created Successfully" });
        }
        // Get

        [HttpGet("Semester")]

        public ActionResult GetAllSemester()
        {
            return new JsonResult(new
            {
                message = " successfuly",
                data = _semesterService.GetAll(),
                success = true
            });
        }

        // Remove

        [HttpPost("Delete/{Id}")]

        public ActionResult RemoveSemester([FromForm] SemesterRequestDTO request)
        {
            return new JsonResult(new
            {
                message = " successfuly",
                data = _semesterService.RemoveSemester(request.Id),
                success = true
            });
        }
    }
}
