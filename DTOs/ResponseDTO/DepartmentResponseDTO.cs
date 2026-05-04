namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class DepartmentResponseDTO : BaseResponseDTO
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int InstituteId { get; set; }
    }
}
