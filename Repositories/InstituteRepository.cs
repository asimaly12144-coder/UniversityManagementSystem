namespace UniversityManagmentSystem.Repositories
{
    public class InstituteRepository : BaseRepository<Models.Institute>, Interfaces.IInstituteRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public InstituteRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    
    }
}
