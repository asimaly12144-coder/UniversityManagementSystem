namespace UniversityManagmentSystem.Repositories
{
    public class FacultyCampusRepository : BaseRepository<Models.FacultyCampus>, Interfaces.IFacultyCampusRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public FacultyCampusRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
