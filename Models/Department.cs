namespace UniversityManagmentSystem.Models
{
    public class Department : BaseModel
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public int InstituteId { get; set; }
        public Institute Institute { get; set; }

        public List<DegreeProgram> DegreePrograms { get; set; }
    }
}
