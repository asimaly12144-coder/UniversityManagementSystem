namespace UniversityManagmentSystem.Repositories
{
    public class SemesterRepository : BaseRepository<Models.Semester>, Interfaces.ISemesterRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public SemesterRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
