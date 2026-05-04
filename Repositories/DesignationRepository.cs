namespace UniversityManagmentSystem.Repositories
{
    public class DesignationRepository : BaseRepository<Models.Designation>, Interfaces.IDesignationRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public DesignationRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
