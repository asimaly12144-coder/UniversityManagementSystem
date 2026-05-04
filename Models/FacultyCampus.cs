namespace UniversityManagmentSystem.Models
{
    public class FacultyCampus : BaseModel
    {
        public int FacultyId { get; set; }
        public int CampusId { get; set; }
        public Campus Campus { get; set; }
        public Faculty Faculty { get; set; }

        public List<Institute> Institutes { get; set; }
    }
    
}
