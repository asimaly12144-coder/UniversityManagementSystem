namespace UniversityManagmentSystem.Models
{
    public class Subject : BaseModel
    {
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<CourseScheme> CourseSchemes { get; set; }
        public List<CloToSubject> CloToSubjects { get; set; }
    }
}
