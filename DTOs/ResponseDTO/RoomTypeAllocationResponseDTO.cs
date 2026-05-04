using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class RoomTypeAllocationResponseDTO : BaseResponseDTO
    {
        public int RoomTypeId { get; set; }
        
        public int RoomId { get; set; }
    }
}
