using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class PloToCloController : BaseController
    {
        private readonly PloToCloServices _ploToCloServices;
        public PloToCloController(PloToCloServices ploToCloServices)
        {
            _ploToCloServices = ploToCloServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllPloToClos()
        {
            return new JsonResult(new { success = true, data = _ploToCloServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] DTOs.RequestDTO.PloToCloRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _ploToCloServices.AddPloToClo(request), message = "Created Successfully" });
        }
        [HttpPost("DeletePloToClo")]
        public IActionResult Delete([FromForm] DTOs.RequestDTO.PloToCloRequestDTO request)
        {
            bool result = _ploToCloServices.RemovePloToClo(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "PLO to CLO mapping not found"
            });
        }
    }
}
