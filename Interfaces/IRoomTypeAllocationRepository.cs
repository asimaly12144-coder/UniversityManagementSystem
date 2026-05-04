namespace UniversityManagmentSystem.Interfaces
{
    public interface IRoomTypeAllocationRepository : IBaseRepository<Models.RoomTypeAllocation>
    {
        public void Save();
    }
}
