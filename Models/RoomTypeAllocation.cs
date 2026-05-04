namespace UniversityManagmentSystem.Models
{
    public class RoomTypeAllocation : BaseModel
    {
        public int RoomTypeId { get; set; }        
        public RoomType RoomType { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }


    }
}
