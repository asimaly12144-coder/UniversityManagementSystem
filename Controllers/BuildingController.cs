using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{

   
    public class BuildingController : BaseController
    
    {
        private readonly BuildingServices _buildingServices;

        public BuildingController(BuildingServices buildingServices)
        {
            _buildingServices = buildingServices;
        }

        [HttpPost("Get")]
        public ActionResult GetBuilding()
        {
            return new JsonResult(new
            {
               success = true, data = _buildingServices.GetAll(), message = " Created Successfully" 

            });
        }
        [HttpPost("Post")]

        public ActionResult AddBuilding([FromForm] BuildingRequestDTO request)
        {
            return new JsonResult(new {
                success = true,
                data = _buildingServices.AddBuilding(request),
                message = " Created Successfully"

            });
        }
        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] UniversityRequestDTO request)
        {
            bool result = _buildingServices.RemoveBuilding(request.Id);

            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Building not found"
            });
        }

    }
}
