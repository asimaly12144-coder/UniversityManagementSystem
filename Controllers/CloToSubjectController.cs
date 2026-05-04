using Microsoft.AspNetCore.Mvc;

namespace UniversityManagmentSystem.Controllers
{
    public class CloToSubjectController : BaseController
    {
        private readonly CloToSubjectServices _cloToSubjectServices;
        public CloToSubjectController(CloToSubjectServices cloToSubjectServices)
        {
            _cloToSubjectServices = cloToSubjectServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllCloToSubjects()
        {
            return new JsonResult(new { success = true, data = _cloToSubjectServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] DTOs.RequestDTO.CloToSubjectRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _cloToSubjectServices.Add(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteCloToSubject")]
        public IActionResult Delete([FromForm] DTOs.RequestDTO.CloToSubjectRequestDTO request)
        {
            bool result = _cloToSubjectServices.Remove(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "CLO to Subject not found"
            });
        }
    }
}
