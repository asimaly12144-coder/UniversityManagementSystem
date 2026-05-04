using System.ComponentModel.DataAnnotations;

namespace UniversityManagmentSystem.Models
{
    public class University : BaseModel
    {
        public string UniversityName { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Address { get; set; }
        public List<Campus> Campuses { get; set; }
    }
}
