using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class CLORequesDTO
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public string Code { get; set; }

        public int SubjectTypeId { get; set; }
        public int LearningLevelId { get; set; }
       

    }
}
