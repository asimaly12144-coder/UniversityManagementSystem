namespace UniversityManagmentSystem.Repositories
{
    public class UserTypeRepository : BaseRepository<Models.UserType>, Interfaces.IUserTypeRepository
    {
        private readonly Data.UniDbContext _context;
        public UserTypeRepository(Data.UniDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
