namespace UniversityManagmentSystem.Repositories
{
    public class LearningLevelRepository : BaseRepository<Models.LearningLevel>, Interfaces.ILearningLevelRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public LearningLevelRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
