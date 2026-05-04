namespace UniversityManagmentSystem.Models
{
    public class UserRight : BaseModel
    {
        public string UserRightCode { get; set; }
        public string UserRightName { get; set; }
        public string URL { get; set; }
        public string TabName { get; set; }

        public List<UserRightAllocation> UserRightAllocations { get; set; } 

    }
}
