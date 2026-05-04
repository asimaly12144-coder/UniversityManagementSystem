using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class CloToSubjectResponseDTO : BaseResponseDTO
    {
        public int CloId { get; set; }
        public int SubjectId { get; set; }
        public int ProgramSessionId { get; set; }
    }
}
