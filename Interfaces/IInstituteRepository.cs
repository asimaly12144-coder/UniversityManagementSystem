namespace UniversityManagmentSystem.Interfaces
{
    public interface IInstituteRepository : IBaseRepository<Models.Institute>
    {
        public void Save();
    }
    
}
