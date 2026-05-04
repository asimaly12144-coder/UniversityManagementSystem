using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{

    public class RoomController : ControllerBase
    {
        private readonly RoomServices _roomServices;
        public RoomController(RoomServices roomService)
        {
            _roomServices = roomService;
        }
        [HttpPost("Get")]
        public ActionResult Post([FromForm] RoomRequestDTO request)
        {
            return new JsonResult(new { message = "True", data = _roomServices.AddRoom(request), success = "Successfully" });
        }
        [HttpPost("Delete")]
        public IActionResult Delete([FromForm] RoomRequestDTO request)
        {
            bool result = _roomServices.RemoveRoom(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Room not found"
            });
        }
        [HttpGet("GetAll")]
        public ActionResult GetAllRooms()
        {
            return new JsonResult(new { success = true, data = _roomServices.GetAll(), message = "Fetched Successfully" });

        }
    }
}
