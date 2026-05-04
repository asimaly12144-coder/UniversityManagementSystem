using System.ComponentModel.DataAnnotations;

namespace UniversityManagmentSystem.Models
{
    public class Campus : BaseModel
    {        
        public string CampusName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Address { get; set; }
        public int UniversityId { get; set; }
        public University University { get; set; }

        public List<Block> Blocks { get; set; }
        public List<FacultyCampus> FacultyCampuses { get; set; }
    }

}
