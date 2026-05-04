namespace UniversityManagmentSystem.Models
{
    public class PeoToPlo : BaseModel
    {
        public int PeoId { get; set; }
        public ProgramEductionOutcomes ProgramEductionOutcomes { get; set; }
        public int PloId { get; set; }
        public ProgramLearningOutcomes ProgramLearningOutcomes { get; set; }
        public string Weightage { get; set; }
    }
}
