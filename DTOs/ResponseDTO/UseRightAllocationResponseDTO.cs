using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class UseRightAllocationResponseDTO : BaseResponseDTO
    {
        public int UserRightId { get; set; }
        public int UserTypeId { get; set; }
    }
}
