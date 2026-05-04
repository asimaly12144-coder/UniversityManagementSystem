namespace UniversityManagmentSystem.Interfaces
{
    public interface ICLORepository : IBaseRepository<Models.CourseLearningOutcomes>
    {
        public void Save();
    }
}
