namespace UniversityManagmentSystem.Repositories
{
    public class ProgramSessionRepository : BaseRepository<Models.ProgramSession>, Interfaces.IProgramSessionRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public ProgramSessionRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
