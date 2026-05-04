using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IStructureTypeRepository : IBaseRepository<StructureType>
    {
        public void Save();

    }
}
