namespace UniversityManagmentSystem.Interfaces
{
    public interface ILearningLevelRepository : IBaseRepository<Models.LearningLevel>
    {
        public void Save();        

    }
}
