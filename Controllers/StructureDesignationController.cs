using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class StructureDesignationController : BaseController
    {
        private readonly StructureDesignationServices _structureDesignationServices;
        public StructureDesignationController(StructureDesignationServices structureDesignationServices)
        {
            _structureDesignationServices = structureDesignationServices;
        }

        [HttpGet("Get")]
        public ActionResult GetAllStructureDesignations()
        {
            return new JsonResult(new { success = true, data = _structureDesignationServices.GetAll(), message = "Retrieved Successfully" });
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] DTOs.RequestDTO.StructureDesignationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _structureDesignationServices.AddStructureDesignation(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteStructureDesignation")]
        public IActionResult Delete([FromBody] DTOs.RequestDTO.StructureDesignationRequestDTO request)
        {
            bool result = _structureDesignationServices.RemoveStructureDesignation(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Structure Designation not found"
            });
        }
    }
}
