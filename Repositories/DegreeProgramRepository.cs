namespace UniversityManagmentSystem.Repositories
{
    public class DegreeProgramRepository : BaseRepository<Models.DegreeProgram>, Interfaces.IDegreeProgramRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public DegreeProgramRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
