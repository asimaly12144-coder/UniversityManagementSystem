namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class RoomResponseDTO : BaseResponseDTO
    {
        public string RoomName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }

        public int FloorId { get; set; }

    }
}
