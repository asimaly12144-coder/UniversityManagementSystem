using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class DegreeLevelController : BaseController
    {
        private readonly DegreeLevelService _degreeLevelService;
        public DegreeLevelController(DegreeLevelService degreeLevelService)
        {
            _degreeLevelService = degreeLevelService;
        }
        [HttpPost("DegreeLevel")]
        public ActionResult Post([FromForm] DegreeLevelRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _degreeLevelService.AddDegreeLevel(request), message = "Created Successfully" });
        }

        // GetAll DegreeLevels

        [HttpGet("DegreeLevels")]
        public ActionResult GetAllDegreeLevels()
        {
            return new JsonResult(new { success = true, data = _degreeLevelService.GetAll(), message = "Retrieved Successfully" });
        }

        // Remove DegreeLevel

        [HttpPost("DegreeLevel/{Id}")]
        public ActionResult RemoveDegreeLevel([FromForm] DegreeLevelRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _degreeLevelService.RemoveDegreeLevel(request.Id), message = "Deleted Successfully" });
        }

    }
}
