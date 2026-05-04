using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IRoomFeatureRepository : IBaseRepository<RoomFeature>
    {
        public void Save();

    }
}
