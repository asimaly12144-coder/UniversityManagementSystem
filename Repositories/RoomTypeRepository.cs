using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class RoomTypeRepository : BaseRepository<Models.RoomType>, IRoomTypeRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public RoomTypeRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
