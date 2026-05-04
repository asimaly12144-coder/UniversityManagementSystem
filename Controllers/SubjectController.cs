using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class SubjectController : BaseController
    {
        private readonly SubjectService _subjectService;
        public SubjectController(SubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        [HttpPost("Subject")]
        public ActionResult Post([FromForm] SubjectRequestDTO request)
        {
            var result = _subjectService.AddSubject(request);
            return new JsonResult(new { success = true, data = result, message = "Subject Created Successfully" });
        }

        [HttpGet("Semester")]

        public ActionResult GetAllSubject()
        {
            return new JsonResult(new
            {
                message = " successfuly Subject get",
                data = _subjectService.GetAll(),
                success = true
            });
        }

        // Remove

        [HttpPost("Delete/{Id}")]

        public ActionResult RemoveSubject([FromForm] SubjectRequestDTO request)
        {
            return new JsonResult(new
            {
                message = " successfuly delete",
                data = _subjectService.RemoveSubject(request.Id),
                success = true
            });
        }
    }
}
