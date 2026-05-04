namespace UniversityManagmentSystem.Models
{
    public class ProgramEductionOutcomes : BaseModel
    {
        public string PEOName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeProgramId { get; set; }
        public DegreeProgram DegreeProgram { get; set; }   
        public List<PeoToPlo> PeoToPlos { get; set; }
     
    }
}
