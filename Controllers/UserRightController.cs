using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserRightController : BaseController
    {
        private readonly UserRightServices _userRightServices;
        public UserRightController(UserRightServices userRightServices)
        {
            _userRightServices = userRightServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllUserRights()
        {
            return new JsonResult(new { success = true, data = _userRightServices.GetAll(), message = "Fetched Successfully" });
        }
        [HttpPost]
        public ActionResult Post([FromBody] UserRightRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _userRightServices.AddUserRight(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteUserRight")]
        public IActionResult Delete([FromBody] UserRightRequestDTO request)
        {
            bool result = _userRightServices.Remove(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "User Right not found"
            });
        }
    }
}
