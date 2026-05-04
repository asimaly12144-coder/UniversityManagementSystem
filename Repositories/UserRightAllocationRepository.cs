namespace UniversityManagmentSystem.Repositories
{
    public class UserRightAllocationRepository : BaseRepository<Models.UserRightAllocation>, Interfaces.IUserRightAllocationRepository
    {
        private readonly Data.UniDbContext _context;
        public UserRightAllocationRepository(Data.UniDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }    
}
