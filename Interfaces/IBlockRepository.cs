using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IBlockRepository : IBaseRepository<Block>
    {
        public void Save();
    }
}
