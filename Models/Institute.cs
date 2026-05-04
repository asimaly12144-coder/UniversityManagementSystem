namespace UniversityManagmentSystem.Models
{
    public class Institute : BaseModel
    {
        public string InstituteName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public DateTime EstablishIn { get; set; } //
        public int FacultyCampusId { get; set; }
        public FacultyCampus FacultyCampus { get; set; }

        public List<Department> Departments { get; set; } 
    }
}
