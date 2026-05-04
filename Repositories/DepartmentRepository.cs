namespace UniversityManagmentSystem.Repositories
{
    public class DepartmentRepository : BaseRepository<Models.Department>, Interfaces.IDepartmentRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public DepartmentRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
