namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserTypeRepository : IBaseRepository<Models.UserType>
    {
        public void Save();
    }
}
