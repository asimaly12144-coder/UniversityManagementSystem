using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class UserInfoRepository : BaseRepository<Models.UserInfo>, IUserInfoRepository
    {
        private readonly UniDbContext _context;
        
        public UserInfoRepository(UniDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        
    }
    
}
