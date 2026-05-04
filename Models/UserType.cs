namespace UniversityManagmentSystem.Models
{
    public class UserType : BaseModel
    {
        public string UserTypeCode { get; set; }
        public string UserTypeName { get; set; }

        public List<UserRightAllocation> UserRightAllocations { get; set; }
        public List<UserTypeAllocation> UserTypeAllocations { get; set; }
    }
}
