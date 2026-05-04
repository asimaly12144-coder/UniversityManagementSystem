using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserInfoController : BaseController
    {
        private readonly UserInfoServices _userInfoServices;
        public UserInfoController(UserInfoServices userInfoServices)
        {
            _userInfoServices = userInfoServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllUserInfos()
        {
            return new JsonResult(new { success = true, data = _userInfoServices.GetAll(), message = "Fetched Successfully" });
        }
        [HttpPost]
        public ActionResult Post([FromBody] UserInfoRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _userInfoServices.AddUserInfo(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteUserInfo")]
        public IActionResult Delete([FromBody] UserInfoRequestDTO request)
        {
            bool result = _userInfoServices.RemoveUserInfo(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "User Info not found"
            });
        }
    }
}
