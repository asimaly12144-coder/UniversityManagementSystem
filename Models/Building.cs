using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace UniversityManagmentSystem.Models
{
    public class Building:BaseModel
    {   
       
        public string BuildingName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Address { get; set; }
      
        // For Building and Block
        public int BlockId { get; set; }
        public Block Block { get; set; }
        public List<Floor> Floors { get; set; }
    }

}
