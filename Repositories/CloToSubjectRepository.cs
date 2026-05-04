namespace UniversityManagmentSystem.Repositories
{
    public class CloToSubjectRepository : BaseRepository<Models.CloToSubject>, Interfaces.ICloToSubjectRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public CloToSubjectRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
