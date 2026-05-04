using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class StructureTypeController : BaseController
    {
        private readonly StructureTypeService _structureTypeService;
        public StructureTypeController(StructureTypeService structureTypeService)
        {
            _structureTypeService = structureTypeService;
        }
        [HttpPost("StructureType")]
        public ActionResult Post([FromForm] StructureTypeRequestDTO request)
        {
            var result = _structureTypeService.AddStructureType(request);
            return new JsonResult(new { success = true, data = result, message = "Structure Type Created Successfully" });
        }

        [HttpGet("Semester")]

        public ActionResult GetAllStructureType()
        {
            return new JsonResult(new
            {
                message = " successfuly StructureType",
                data = _structureTypeService.GetAll(),
                success = true
            });
        }

        // Remove

        [HttpPost("Delete/{Id}")]

        public ActionResult RemoveStructureType([FromForm] StructureTypeRequestDTO request)
        {
            return new JsonResult(new
            {
                message = " successfuly",
                data = _structureTypeService.RemoveStructureType(request.Id),
                success = true
            });
        }
    }
}
