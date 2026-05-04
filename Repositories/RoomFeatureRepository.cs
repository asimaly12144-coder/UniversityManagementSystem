using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class RoomFeatureRepository : BaseRepository<Models.RoomFeature>, IRoomFeatureRepository
    {
        private readonly UniDbContext _mVC_Db_Context;
        public RoomFeatureRepository(UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
