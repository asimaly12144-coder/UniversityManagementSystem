namespace UniversityManagmentSystem.Repositories
{
    public class PLORepository : BaseRepository<Models.ProgramLearningOutcomes>, Interfaces.IPLORepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public PLORepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
