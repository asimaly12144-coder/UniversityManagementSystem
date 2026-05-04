using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class RoomFeatureAllocationResponseDTO : BaseResponseDTO
    {
        public int RoomFeatureId { get; set; }

        public int RoomId { get; set; }

        public int Quantity { get; set; }
    }
}
