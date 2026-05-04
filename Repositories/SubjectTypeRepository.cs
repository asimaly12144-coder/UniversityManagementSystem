namespace UniversityManagmentSystem.Repositories
{
    public class SubjectTypeRepository : BaseRepository<Models.SubjectType>, Interfaces.ISubjectTypeRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public SubjectTypeRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
