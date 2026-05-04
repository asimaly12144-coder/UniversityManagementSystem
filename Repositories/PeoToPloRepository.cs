namespace UniversityManagmentSystem.Repositories
{
    public class PeoToPloRepository : BaseRepository<Models.PeoToPlo>, Interfaces.IPeoToPloRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public PeoToPloRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
