namespace UniversityManagmentSystem.Repositories
{
    public class RoomRepository : BaseRepository<Models.Room>, Interfaces.IRoomRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public RoomRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }

    }
}
