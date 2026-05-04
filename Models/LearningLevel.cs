namespace UniversityManagmentSystem.Models
{
    public class LearningLevel : BaseModel
    {
        public string LearningLevelName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<CourseLearningOutcomes> CourseLearningOutcomes { get; set; }
    }
}
