namespace UniversityManagmentSystem.Models
{
    public class UserInfo : BaseModel
    {
        public string UserName { get; set; }
        public string UiUser { get; set; }
        public string UiPassword { get; set; }

        public List<UserTypeAllocation> UserTypeAllocations { get; set; }

    }
}
