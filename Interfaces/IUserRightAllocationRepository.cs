namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserRightAllocationRepository : IBaseRepository<Models.UserRightAllocation>
    {
        public void Save();
    }
    
}
