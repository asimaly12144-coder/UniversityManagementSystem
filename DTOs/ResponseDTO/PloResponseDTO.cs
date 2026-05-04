namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class PloResponseDTO : BaseResponseDTO
    {
        public string PLOName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeProgramId { get; set; }
    }
}
