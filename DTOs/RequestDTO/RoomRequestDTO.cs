namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class RoomRequestDTO
    {
        public int Id { get; set; }

        public string RoomName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public int FloorId { get; set; }

    }
}
