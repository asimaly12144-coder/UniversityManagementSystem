namespace UniversityManagmentSystem.Models
{
    public class CloToSubject : BaseModel
    {
        public int CloId { get; set; }
        public CourseLearningOutcomes Clo { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int ProgramSessionId { get; set; }
        public ProgramSession ProgramSession { get; set; }

    }
}
