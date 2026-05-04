using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class RoomFeatureAllocationController : BaseController
    {
        private readonly RoomFeatureAllocationServices _roomFeatureAllocationServices;

        public RoomFeatureAllocationController(RoomFeatureAllocationServices roomFeatureAllocationServices)
        {
            _roomFeatureAllocationServices = roomFeatureAllocationServices;
        }
        [HttpPost("Get")]
        public ActionResult GetRoomFeatureAllocation()
        {
            return new JsonResult(new { success = true, data = _roomFeatureAllocationServices.GetAll(), message = " Created Successfully" });

        }
        [HttpPost("Post")]
        public ActionResult AddRoomFeatureAllocation([FromForm] RoomFeatureAllocationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _roomFeatureAllocationServices.AddRoomFeatureAllocation(request), message = " Created Successfully" });

        }
       
        [HttpPost("Delete")]
        public ActionResult DeleteRoomFeatureAllocation(RoomFeatureAllocationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _roomFeatureAllocationServices.RemoveRoomFeatureAllocation(request.Id), message = " Delete Successfully" });

        }
    }
}
