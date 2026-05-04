namespace UniversityManagmentSystem.Interfaces
{
    public interface IPLORepository : IBaseRepository<Models.ProgramLearningOutcomes>
    {
        public void Save();
    }
}
