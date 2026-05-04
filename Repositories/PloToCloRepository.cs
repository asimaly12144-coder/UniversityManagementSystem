namespace UniversityManagmentSystem.Repositories
{
    public class PloToCloRepository : BaseRepository<Models.PloToClo>, Interfaces.IPloToCloRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public PloToCloRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
