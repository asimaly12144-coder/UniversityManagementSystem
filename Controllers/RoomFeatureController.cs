using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class RoomFeatureController : BaseController
    {
        private readonly RoomFeatureService _roomFeatureService;
        public RoomFeatureController(RoomFeatureService roomFeatureService)
        {
            _roomFeatureService = roomFeatureService;
        }
        [HttpPost("RoomFeature")]

        public ActionResult Post([FromForm] RoomFeatureRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _roomFeatureService.AddRoomFeature(request) , message= "Successfully Execute" });
        }

        [HttpGet("RoomFeature Get")]
        public ActionResult GetAllRoomFeature()
        {
            return new JsonResult(new { success = true, data = _roomFeatureService.GetAll(), message = "Successfully" });
        }

        [HttpPost("Delete/{Id}")]
        public ActionResult RemoveRoomFeature([FromForm] ProgramSessionRequestDTO request)
        {
            return new JsonResult(new { message = true, data = _roomFeatureService.RemoveRoomFeature(request.Id) });
        }
    }
}
