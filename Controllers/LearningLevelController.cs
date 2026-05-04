using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class LearningLevelController : BaseController
    {
        private readonly LearningLevelServices _learningLevelServices;
        public LearningLevelController(LearningLevelServices learningLevelServices)
        {
            _learningLevelServices = learningLevelServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllLearningLevels()
        {
            return new JsonResult(new { success = true, data = _learningLevelServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] DTOs.RequestDTO.LearningLevelRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _learningLevelServices.AddLearningLevel(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteLearningLevel")]
        public IActionResult Delete([FromBody] DTOs.RequestDTO.LearningLevelRequestDTO request)
        {
            bool result = _learningLevelServices.RemoveLearningLevel(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Learning Level not found"
            });
        }
    }
}
