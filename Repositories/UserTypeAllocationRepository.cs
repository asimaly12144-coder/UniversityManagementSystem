namespace UniversityManagmentSystem.Repositories
{
    public class UserTypeAllocationRepository : BaseRepository<Models.UserTypeAllocation>, Interfaces.IUserTypeAllocationRepository
    {
        private readonly Data.UniDbContext _context;
        public UserTypeAllocationRepository(Data.UniDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
