using UniversityManagmentSystem.Data;

namespace UniversityManagmentSystem.Repositories
{
    public class UserRightRepository : BaseRepository<Models.UserRight>, Interfaces.IUserRightRepository
    {
        private readonly UniDbContext _context;

        public UserRightRepository(UniDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
