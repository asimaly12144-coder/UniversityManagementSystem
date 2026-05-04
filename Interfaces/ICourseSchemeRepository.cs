namespace UniversityManagmentSystem.Interfaces
{
    public interface ICourseSchemeRepository : IBaseRepository<Models.CourseScheme>
    {
        public void Save();
    }
    
}
