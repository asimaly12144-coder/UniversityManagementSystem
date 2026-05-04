namespace UniversityManagmentSystem.Interfaces
{
    public interface IDegreeProgramRepository : IBaseRepository<Models.DegreeProgram>
    {
        public void Save();
    }
}
