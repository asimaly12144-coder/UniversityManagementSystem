namespace UniversityManagmentSystem.Repositories
{
    public class CLORepository : BaseRepository<Models.CourseLearningOutcomes>, Interfaces.ICLORepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public CLORepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
