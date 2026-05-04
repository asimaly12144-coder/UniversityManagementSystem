using Microsoft.AspNetCore.Mvc;

namespace UniversityManagmentSystem.Controllers
{
    public class DepartmentController : BaseController
    {
        private readonly DepartmentServices _departmentServices;
        public DepartmentController(DepartmentServices departmentServices)
        {
            _departmentServices = departmentServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllDepartments()
        {
            return new JsonResult(new { success = true, data = _departmentServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] DTOs.RequestDTO.DepartmentRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _departmentServices.AddDepartment(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteDepartment")]
        public IActionResult Delete([FromForm] DTOs.RequestDTO.DepartmentRequestDTO request)
        {
            bool result = _departmentServices.RemoveDepartment(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Department not found"
            });
        }
    }
}
