using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class SubjectTypeController : BaseController
    {
        private readonly SubjectTypeService _subjectTypeService;
        public SubjectTypeController(SubjectTypeService subjectTypeService)
        {
            _subjectTypeService = subjectTypeService;
        }
        [HttpPost("SubjectType")]
        public ActionResult Post([FromForm] SubjectTypeRequestDTO request)
        {
            var result = _subjectTypeService.AddSubjectType(request);
            return new JsonResult(new { success = true, data = result, message = "Subject Type Created Successfully" });
        }

        [HttpGet("Semester")]

        public ActionResult GetAllSubjectType()
        {
            return new JsonResult(new
            {
                message = " successfuly get",
                data = _subjectTypeService.GetAll(),
                success = true
            });
        }

        // Remove

        [HttpPost("Delete/{Id}")]

        public ActionResult RemoveSubjectType([FromForm] SubjectRequestDTO request)
        {
            return new JsonResult(new
            {
                message = " successfuly Delete",
                data = _subjectTypeService.RemoveSubjectType(request.Id),
                success = true
            });
        }

    }
}
