using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserInfoRepository : IBaseRepository<UserInfo>
    {
        public void Save();
    }
}
