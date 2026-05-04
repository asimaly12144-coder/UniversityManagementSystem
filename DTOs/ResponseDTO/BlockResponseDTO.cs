namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class BlockResponseDTO : BaseResponseDTO
    {
        public string BlockName { get; set; }
        public string BlockCode { get; set; }
        public string BlockDescription { get; set; }
        public string Address { get; set; } //

        public DateTime EstablishedIn { get; set; }
        public int CampusId { get; set; }
    }
}
