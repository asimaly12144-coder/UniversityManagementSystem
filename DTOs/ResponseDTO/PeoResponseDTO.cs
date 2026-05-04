namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class PeoResponseDTO : BaseResponseDTO
    {
        public string PEOName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeProgramId { get; set; }
    }
}
