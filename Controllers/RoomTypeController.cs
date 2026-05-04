using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{

    public class RoomTypeController : BaseController
    {
        private readonly RoomTypeService _roomTypeService;
        public RoomTypeController(RoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }
        [HttpPost("RoomType")]
        public ActionResult Post([FromForm] RoomTypeRequestDTO request)
        {
            var result = _roomTypeService.AddRoomType(request);
            return new JsonResult(new { success = true, data = result, message = "Room Type Created Successfully" });

        }

        //Get
        [HttpGet("Get")]
        public ActionResult GellAllRoomType()
        {
            return new JsonResult(new { message = "SuccessFully", data=_roomTypeService.GetAll(), success=true});
        }

        // Remove
        [HttpPost("Delete")]
        public ActionResult RemoveRoomType([FromForm] RoomFeatureRequestDTO request)
        {
            return new JsonResult(new { succes = true, message = "Delete Successfully", data = _roomTypeService.RemoveRoomType(request.Id) });
        }
    }
}
