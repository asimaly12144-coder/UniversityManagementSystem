namespace UniversityManagmentSystem.Interfaces
{
    public interface IDepartmentRepository : IBaseRepository<Models.Department>
    {
        public void Save();
    }
}
