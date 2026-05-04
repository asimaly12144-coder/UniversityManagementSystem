namespace UniversityManagmentSystem.Repositories
{
    public class DegreeLevelRepository : BaseRepository<Models.DegreeLevel>, Interfaces.IDegreeLevelRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public DegreeLevelRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
