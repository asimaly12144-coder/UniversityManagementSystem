namespace UniversityManagmentSystem.Models
{
    public class UserTypeAllocation : BaseModel
    {
        public int UserTypeId { get; set; }
        public int UserInfoId { get; set; }
       
        public UserType UserTypes { get; set; }
        public UserInfo UserInfos { get; set; }
    }
   
}
