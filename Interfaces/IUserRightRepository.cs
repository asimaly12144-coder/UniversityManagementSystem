namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserRightRepository : IBaseRepository<Models.UserRight>
    {
        public void Save();
    }
}
