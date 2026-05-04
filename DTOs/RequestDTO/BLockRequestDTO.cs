using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class BLockRequestDTO
    {
        public int Id { get; set; }

        public string BlockName { get; set; }
        public string BlockCode { get; set; }
        public string BlockDescription { get; set; }
        public string Address { get; set; } //


        public int CampusId { get; set; }
        
    }
}
