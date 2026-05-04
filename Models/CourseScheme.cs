namespace UniversityManagmentSystem.Models
{
    public class CourseScheme : BaseModel
    {
        public int ProgramSessionId { get; set; }
        public ProgramSession ProgramSession { get; set; }
        public int DegreeProgramId { get; set; }
        public DegreeProgram DegreeProgram { get; set; }

        public int SubjectTypeId { get; set; }
        public SubjectType SubjectType { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }
    }
}
