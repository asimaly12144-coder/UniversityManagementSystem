using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ISemesterRepository : IBaseRepository<Semester>
    {
        public void Save();
    }
    
}
