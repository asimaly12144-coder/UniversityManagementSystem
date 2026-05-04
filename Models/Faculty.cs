namespace UniversityManagmentSystem.Models
{
    public class Faculty : BaseModel
    {
        public string FacultyName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public DateTime EstablishedIn { get; set; } //
        public List<FacultyCampus> FacultyCampuses { get; set; }
    }
}
