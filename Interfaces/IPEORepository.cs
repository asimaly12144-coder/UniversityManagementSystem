namespace UniversityManagmentSystem.Interfaces
{
    public interface IPEORepository : IBaseRepository<Models.ProgramEductionOutcomes>
    {
        public void Save();
    }
}
