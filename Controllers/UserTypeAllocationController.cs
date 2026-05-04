using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserTypeAllocationController : BaseController
    { 
        private readonly UserTypeAllocationServices _userTypeAllocationServices;
        public UserTypeAllocationController(UserTypeAllocationServices userTypeAllocationServices)
        {
            _userTypeAllocationServices = userTypeAllocationServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllUserTypes()
        {
            return new JsonResult(new { success = true, data = _userTypeAllocationServices.GetAll(), message = "Fetched Successfully" });
        }
        [HttpPost]
        public ActionResult Post([FromBody] UserTypeAllocationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _userTypeAllocationServices.AddUserTypeAllocation(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteUserType")]
        public IActionResult Delete([FromBody] UserTypeAllocationRequestDTO request)
        {
            bool result = _userTypeAllocationServices.Remove(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "User Type not found"
            });
        }
    }
}
