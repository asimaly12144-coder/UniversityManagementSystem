using System.ComponentModel.DataAnnotations;

namespace UniversityManagmentSystem.Models
{
    public class Floor : BaseModel
    {
        
        public string FloorName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        //public string Address { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public List<Room> Rooms { get; set; }





    }

}
