namespace UniversityManagmentSystem.Interfaces
{
    public interface IBuildingRepository : IBaseRepository<Models.Building>
    {
        public void Save();
    }
}
