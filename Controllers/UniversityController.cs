using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UniversityController: BaseController
    {
         private readonly UniversityServices _universityServices;
         public UniversityController(UniversityServices universityServices)
            {
                _universityServices = universityServices;
         }
        [HttpGet("Get")]
        public ActionResult GetAllUniversities()
        {
            return new JsonResult(new {success= true, data = _universityServices.GetAll() , message = " Created Successfully"});
        }
        [HttpPost]
        public ActionResult Post([FromBody] UniversityRequestDTO request)
        {
            return new JsonResult(new {success= true, data = _universityServices.AddUniversity(request) , message = " Created Successfully"});
        }
        [HttpPost("DeleteUniversity")]
        public IActionResult Delete([FromBody] UniversityRequestDTO request)
        {
            bool result = _universityServices.RemoveUniversity(request.Id);

            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "University not found"
            });
        }




    }
}
