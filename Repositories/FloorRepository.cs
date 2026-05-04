namespace UniversityManagmentSystem.Repositories
{
    public class FloorRepository : BaseRepository<Models.Floor>, Interfaces.IFloorRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public FloorRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
