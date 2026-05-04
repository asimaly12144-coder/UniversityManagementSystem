namespace UniversityManagmentSystem.Models
{
    public class DegreeProgram : BaseModel
    {
        public string DegreeProgramName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeLevelId { get; set; }
        public DegreeLevel DegreeLevel { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<CourseScheme> CourseSchemes { get; set; }
        public List<ProgramEductionOutcomes> ProgramEductionOutcomes { get; set; }

        public List<ProgramLearningOutcomes> ProgramLearningOutcomes {  get; set; }
    }
}
