using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserTypeController : BaseController

    {
        private readonly UserTypeServices _userTypeServices;
        public UserTypeController(UserTypeServices userTypeServices)
        {
            _userTypeServices = userTypeServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllUserTypes()
        {
            return new JsonResult(new { success = true, data = _userTypeServices.GetAll(), message = "Fetched Successfully" });
        }
        [HttpPost]
        public ActionResult Post([FromBody] UserTypeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _userTypeServices.AddUserType(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteUserType")]
        public IActionResult Delete([FromBody] UserTypeRequestDTO request)
        {
            bool result = _userTypeServices.Remove(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "User Type not found"
            });
        }
    }
}
