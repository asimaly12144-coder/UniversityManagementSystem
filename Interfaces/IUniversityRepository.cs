using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IUniversityRepository : IBaseRepository<University>
    {
        public void Save();
    }
}
