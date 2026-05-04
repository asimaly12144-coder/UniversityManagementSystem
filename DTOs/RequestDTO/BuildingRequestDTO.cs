using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class BuildingRequestDTO
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Address { get; set; }

        // For Building and Block
        public int BlockId { get; set; }
       
    }
}
