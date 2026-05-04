using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Repositories;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserRightAllocationController : BaseController
    {
        private readonly UserRightAllocationServices _userRightAllocationServices;
        public UserRightAllocationController(UserRightAllocationServices userRightAllocationServices)
        {
            _userRightAllocationServices = userRightAllocationServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllUserRights()
        {
            return new JsonResult(new { success = true, data = _userRightAllocationServices.GetAll(), message = "Fetched Successfully" });
        }
        [HttpPost]
        public ActionResult Post([FromBody] UserRightAllocationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _userRightAllocationServices.AddUserRightAllocation(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteUserRight")]
        public IActionResult Delete([FromBody] UserRightAllocationRequestDTO request)
        {
            bool result = _userRightAllocationServices.Remove(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "User Right not found"
            });
        }
    }
}
