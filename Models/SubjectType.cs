namespace UniversityManagmentSystem.Models
{
    public class SubjectType : BaseModel
    {
        public string TypeName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public List<CourseLearningOutcomes> CourseLearningOutcomes { get; set; }

        public List<CourseScheme> CourseSchemes { get; set; }
    }
}
