using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IRoomTypeRepository : IBaseRepository<RoomType>
    {
        public void Save();

    }
}
