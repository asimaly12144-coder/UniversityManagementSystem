using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;
namespace UniversityManagmentSystem.Controllers
{
   
    public class BlockController : BaseController
    {
        private readonly BlockServices _blockServices;
        public BlockController(BlockServices blockServices)
        {
            _blockServices = blockServices;
        }
        [HttpGet("Get")]
        public ActionResult GetAllBlocks()
        {
            return new JsonResult(new { success = true, data = _blockServices.GetAll(), message = "Retrieved Successfully" });
        }
        [HttpPost("Post")]
        public ActionResult Post([FromForm] BLockRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _blockServices.AddBlock(request), message = "Created Successfully" });
        }
        [HttpPost("DeleteBlock")]
        public IActionResult Delete([FromForm] BLockRequestDTO request)
        {
            bool result = _blockServices.RemoveBlock(request.Id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Block not found"
            });
        }
    }
}