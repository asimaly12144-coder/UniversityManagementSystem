namespace UniversityManagmentSystem.Models
{
    public class CourseLearningOutcomes : BaseModel
    {
        public string Description { get; set; }
        public string Code { get; set; }

        public int SubjectTypeId { get; set; }
        public SubjectType SubjectType { get; set; }
        public int LearningLevelId { get; set; }
        public LearningLevel LearningLevel { get; set; }
        public List<PloToClo> PloToClos { get; set; }
        public List<CloToSubject> CloToSubjects { get; set; }
    }
}
