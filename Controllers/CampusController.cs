using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    
    public class CampusController : BaseController
    {
        private readonly CampusServices _campusServices;

        public CampusController(CampusServices campusServices)
        {
            _campusServices = campusServices;
        }

        [HttpPost("Get")]
        public ActionResult GetCampus()
        {
            return new JsonResult(new
            {
                success = true,
                data = _campusServices.GetAll(),
                message = "Successfully"

            });
        }
        [HttpPost("Post")]

        public ActionResult AddBuilding([FromForm] CampusRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _campusServices.AddCampus(request),
                message = " Created Successfully"

            });
        }
        [HttpPost("Delete")]
        public IActionResult Delete([FromForm] CampusRequestDTO request)
        {
            bool result = _campusServices.RemoveCampus(request.Id);

            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Campus not found"
            });
        }

        // [HttpPost("Edit")]
        [HttpPut("Edit")]
        public ActionResult Edit([FromForm] CampusRequestDTO request)
        {
            Campus campus = _campusServices.EditCampus(request);
           
            return new JsonResult(new
            {
                success = true,
                data = campus,
                message = "Updated Successfully"
            });
        }
    }
}
