using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class FloorRequestDTO
    {
        public int Id { get; set; }

        public string FloorName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }

        public int BuildingId { get; set; }
       
    }
}
