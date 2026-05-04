using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Controllers
{
    public class DegreeProgramController : BaseController
    {
        private readonly DegreeProgramServices _degreeProgramServices;

        public DegreeProgramController(DegreeProgramServices degreeProgramServices)
        {
            _degreeProgramServices = degreeProgramServices;
        }
        [HttpPost("Get")]
        public ActionResult AddDegreeProgram(DegreeProgramRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _degreeProgramServices.AddDegreeProgram(request),
                message= "Successfully"
            });
        }
        [HttpPost("Delete")]
        public ActionResult DeleteDegProgram(int? Id)
        {
            return new JsonResult(new
            {
                data = _degreeProgramServices.RemoveDegreeProgram(Id),
                success = true,

            });
        }
    }
}
