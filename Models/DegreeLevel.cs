namespace UniversityManagmentSystem.Models
{
    public class DegreeLevel : BaseModel
    {
        public string DegreeLevelName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public List<DegreeProgram> DegreePrograms { get; set; }
    }
}
