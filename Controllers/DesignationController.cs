using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class DesignationController : BaseController
    {
        private readonly DesignationService _designationServices;
        public DesignationController(DesignationService designationServices)
        {
            _designationServices = designationServices;
        }


        [HttpPost("Designation")]
        public ActionResult Post([FromForm] DesignationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _designationServices.AddDesignation(request), message = "Created Successfully" });
        }
        [HttpGet("Designation Get All Data")]
        public ActionResult GetAll()
        {
            return new JsonResult(new { success = true, data = _designationServices.GetAll(), message = "Fetched Successfully" });
        }
        [HttpPost("Designation Delete/{id}")]
        public ActionResult Delete([FromForm] DesignationRequestDTO request)
        {        
            return new JsonResult(new { success = true, data =_designationServices.RemoveDesignation(request.Id) , message = "Deleted Successfully" });
        }
    }
}
