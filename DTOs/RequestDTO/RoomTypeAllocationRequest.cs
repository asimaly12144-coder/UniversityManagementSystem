using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class RoomTypeAllocationRequest
    {
        public int Id { get; set; }

        public int RoomTypeId { get; set; }
        public int RoomId { get; set; }
    }
}
