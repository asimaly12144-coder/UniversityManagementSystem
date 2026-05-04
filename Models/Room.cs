namespace UniversityManagmentSystem.Models
{
    public class Room : BaseModel
    {      
        public string RoomName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        //public string Address { get; set; }

        public int FloorId { get; set; }

        public Floor Floor { get; set; }
        public List<RoomTypeAllocation> RoomTypeAllocations { get; set; }
        public List<RoomFeatureAllocation> RoomFeatureAllocations { get; set; }
    }

}
