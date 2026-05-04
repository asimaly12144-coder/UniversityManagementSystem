using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;

namespace UniversityManagmentSystem.Controllers
{
    public class CLOController : BaseController
    {
        private readonly CLOServices _cloServices;
        public CLOController(CLOServices cloServices)
        {
            _cloServices = cloServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllCLOs()
        {
            return new JsonResult(new { success = true, data = _cloServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] CLORequesDTO request)
        {
            return new JsonResult(new { success = true, data = _cloServices.AddCLO(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteCLO")]
        public IActionResult Delete([FromForm] CLORequesDTO request)
        {
            bool result = _cloServices.RemoveCLO(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "CLO not found"
            });
        }
    }
}
