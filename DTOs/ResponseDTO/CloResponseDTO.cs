using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class CloResponseDTO : BaseResponseDTO
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public int SubjectTypeId { get; set; }       
        public int LearningLevelId { get; set; }
    }
}
