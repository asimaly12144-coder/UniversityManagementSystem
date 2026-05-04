using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class ProgramSessionController : BaseController
    {
        private readonly ProgramSessionService _programSessionService;
        public ProgramSessionController(ProgramSessionService programSessionService)
        {
            _programSessionService = programSessionService;
        }

        [HttpPost("ProgramSession")]
        public ActionResult PostProgramSession([FromForm] ProgramSessionRequestDTO request)
        {
            var result = _programSessionService.AddProgramSession(request);
            return new JsonResult(new { success = true, data = result, message = "Program Session Created Successfully" });
        }
        // Get
        [HttpPost("ProgramSessionGet")]
        public ActionResult GetAllProgramSession()
        {
            return new JsonResult(new { message = "All Program Session", data = _programSessionService.GetAll(), success = true });
        }

        // Remove 
        [HttpPost(" delete")]
        public ActionResult RemoveProgramSession([FromForm] ProgramSessionRequestDTO request)
        {
            return new JsonResult(new { message = "delet Program Session Succesfuly", data = _programSessionService.RemoveProgramSession(request.Id), success = true });

        }
    }
}
