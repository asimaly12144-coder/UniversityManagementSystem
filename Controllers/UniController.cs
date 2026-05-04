using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UniController : ControllerBase
    {
        private readonly UniDbContext uniDbContext;
        public UniController(UniDbContext _uniDbContext)
        {
            uniDbContext = _uniDbContext;
        }
        [HttpPost]

        public ActionResult Post([FromForm] University university)
        {
            uniDbContext.Add(university);
            uniDbContext.SaveChanges();

            return new JsonResult(new { message = "True" });
        }
    }
}
