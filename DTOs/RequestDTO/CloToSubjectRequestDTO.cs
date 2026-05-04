using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class CloToSubjectRequestDTO
    {
        public int Id { get; set; }

        public int CloId { get; set; }
       
        public int SubjectId { get; set; }
       
        public int ProgramSessionId { get; set; }
       
    }
}
