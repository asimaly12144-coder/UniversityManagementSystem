using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IDesignationRepository : IBaseRepository<Designation>
    {
        public void Save();

    }
}
