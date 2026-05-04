namespace UniversityManagmentSystem.Interfaces
{
    public interface ICloToSubjectRepository : IBaseRepository<Models.CloToSubject>
    {
        public void Save();
    }
}
