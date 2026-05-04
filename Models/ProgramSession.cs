namespace UniversityManagmentSystem.Models
{
    public class ProgramSession : BaseModel
    {
        public string SessionName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<CourseScheme> CourseSchemes { get; set; }
        public List<ProgramSession> ProgramSessions { get; set; }
        public List<CloToSubject> CloToSubjects { get; set; }
    }
}
