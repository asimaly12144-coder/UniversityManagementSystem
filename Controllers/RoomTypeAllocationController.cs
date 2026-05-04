using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class RoomTypeAllocationController : BaseController
    {
        private readonly RoomTypeAllocationServices _roomTypeAllocationServices;
        public RoomTypeAllocationController(RoomTypeAllocationServices roomTypeAllocationServices)
        {
            _roomTypeAllocationServices = roomTypeAllocationServices;
        }

        [HttpGet("Get")]
        public ActionResult GetAllRoomTypeAllocations()
        {
            return new JsonResult(new { success = true, data = _roomTypeAllocationServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] RoomTypeAllocationRequest request)
        {
            return new JsonResult(new { success = true, data = _roomTypeAllocationServices.AddRoomTypeAllocation(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteRoomTypeAllocation")]
        public IActionResult Delete([FromBody] RoomTypeAllocationRequest request)
        {
            bool result = _roomTypeAllocationServices.RemoveRoomTypeAllocation(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Room Type Allocation not found"
            });
        }

    }
}
