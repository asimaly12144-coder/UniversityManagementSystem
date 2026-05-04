using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class DegreeProgramResponseDTO : BaseResponseDTO
    {
        public string LevelName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeLevelId { get; set; }
        public int DepartmentId { get; set; }
    }
}
