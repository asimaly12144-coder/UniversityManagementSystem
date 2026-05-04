namespace UniversityManagmentSystem.Repositories
{
    public class RoomFeatureAllocationRepository : BaseRepository<Models.RoomFeatureAllocation>, Interfaces.IRoomFeatureAllocationRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public RoomFeatureAllocationRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
