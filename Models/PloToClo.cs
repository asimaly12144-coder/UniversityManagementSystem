namespace UniversityManagmentSystem.Models
{
    public class PloToClo : BaseModel
    {
   
        public int PloId { get; set; }
        public ProgramEductionOutcomes PEO { get; set; }
        public int CloId { get; set; }
        public CourseLearningOutcomes Clo { get; set; }   
        
        public string Weightage { get; set; }
    }
}

