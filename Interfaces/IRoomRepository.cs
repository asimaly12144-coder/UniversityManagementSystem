namespace UniversityManagmentSystem.Interfaces
{
    public interface IRoomRepository : IBaseRepository<Models.Room>
    {
        public void Save();
    }
    
}
