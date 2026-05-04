namespace UniversityManagmentSystem.Models
{
    public class RoomType : BaseModel
    {
       
        public string RoomTypeName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public DateTime EstablishedIn { get; set; } 
        public List<RoomTypeAllocation> RoomTypeAllocations { get; set; }
    }

}
