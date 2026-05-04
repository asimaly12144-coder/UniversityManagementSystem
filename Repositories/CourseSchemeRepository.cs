namespace UniversityManagmentSystem.Repositories
{
    public class CourseSchemeRepository : BaseRepository<Models.CourseScheme>, Interfaces.ICourseSchemeRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public CourseSchemeRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
