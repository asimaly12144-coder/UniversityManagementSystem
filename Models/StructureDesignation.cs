namespace UniversityManagmentSystem.Models
{
    public class StructureDesignation : BaseModel
    {
        public int StructureUnitId { get; set; } 
        public StructureUnit StructureUnit { get; set; } 

        public int DesignationId { get; set; }
        public Designation Designation { get; set; }
    }
}
