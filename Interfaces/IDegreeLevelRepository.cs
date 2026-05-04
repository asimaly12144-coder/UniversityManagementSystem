using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IDegreeLevelRepository : IBaseRepository<DegreeLevel>
    {
        public void Save();

    }
}
