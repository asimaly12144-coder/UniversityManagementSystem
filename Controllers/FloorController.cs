using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
   
    public class FloorController : BaseController
    {
        private readonly FloorServices _floorServices;
        public FloorController(FloorServices floorServices)
        {
            _floorServices = floorServices;
        }
        [HttpPost("Post")]

        public ActionResult Post([FromForm] FloorRequestDTO request)
        {           

            return new JsonResult(new { message = "True" , data = _floorServices.AddFloor(request) , success = true});
        }
        [HttpPost("Delete")]
        public ActionResult DeleteFloor(FloorRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _floorServices.RemoveFloor(request.Id), message = " Delete Successfully" });

        }
        [HttpGet("Get")]
        public ActionResult GetAllFloor()
        {
            return new JsonResult(new { success = true, data = _floorServices.GetAll(), message = " Created Successfully" });
        }
    }
}
