namespace UniversityManagmentSystem.Models
{
    public class ProgramLearningOutcomes : BaseModel
    {
       
        public string PLOName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeProgramId { get; set; }
        public DegreeProgram DegreeProgram { get; set; }
        public List<PloToClo> PloToClos { get; set; }
        public List<PeoToPlo> PeoToPlos { get; set; }
    }
}
