namespace UniversityManagmentSystem.Repositories
{
    public class FacultyRepository : BaseRepository<Models.Faculty>, Interfaces.IFacultyRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public FacultyRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
