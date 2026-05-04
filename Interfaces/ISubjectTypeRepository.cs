namespace UniversityManagmentSystem.Interfaces
{
    public interface ISubjectTypeRepository : IBaseRepository<Models.SubjectType>
    {
        public void Save();
    }
    
}
