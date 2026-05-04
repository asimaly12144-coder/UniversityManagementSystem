namespace UniversityManagmentSystem.Repositories
{
    public class CampusRepository : BaseRepository<Models.Campus>, Interfaces.ICampusRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public CampusRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
