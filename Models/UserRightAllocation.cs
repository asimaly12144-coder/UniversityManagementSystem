namespace UniversityManagmentSystem.Models
{
    public class UserRightAllocation : BaseModel
    {
        public int UserRightId { get; set; }
        public int UserTypeId { get; set; }
        public UserRight UserRights { get; set; }
        public UserType UserTypes { get; set; }
    }
   
}
