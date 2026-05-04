namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class FloorResponseDTO : BaseResponseDTO
    {
        public string FloorName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Address { get; set; }
        public int BuildingId { get; set; }
    }
}
