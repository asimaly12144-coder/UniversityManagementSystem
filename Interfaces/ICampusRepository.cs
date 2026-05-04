namespace UniversityManagmentSystem.Interfaces
{
    public interface ICampusRepository : IBaseRepository<Models.Campus>
    {
        public void Save();
    }
}
