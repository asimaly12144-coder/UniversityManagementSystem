namespace UniversityManagmentSystem.Repositories
{
    public class RoomTypeAllocationRepository : BaseRepository<Models.RoomTypeAllocation>, Interfaces.IRoomTypeAllocationRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public RoomTypeAllocationRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
