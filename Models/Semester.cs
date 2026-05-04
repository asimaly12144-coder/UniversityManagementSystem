namespace UniversityManagmentSystem.Models
{
    public class Semester : BaseModel
    {
        public string SemesterName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public List<CourseScheme> CourseSchemes { get; set; }
    }
}
