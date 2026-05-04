using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class UserTypeAllocationResponseDTO : BaseResponseDTO
    {
        public int UserTypeId { get; set; }
        public int UserInfoId { get; set; }
    }
}
