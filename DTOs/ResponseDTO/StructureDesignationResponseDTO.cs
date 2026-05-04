using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class StructureDesignationResponseDTO : BaseResponseDTO
    {
        public int StructureUnitId { get; set; }

        public int DesignationId { get; set; }
    }
}
