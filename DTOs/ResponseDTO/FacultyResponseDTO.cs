namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class FacultyResponseDTO : BaseResponseDTO
    {
        public string FacultyName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public DateTime EstablishedIn { get; set; } //

    }
}
