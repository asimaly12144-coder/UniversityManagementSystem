namespace UniversityManagmentSystem.Interfaces
{
    public interface IRoomFeatureAllocationRepository : IBaseRepository<Models.RoomFeatureAllocation>
    {
        public void Save();
    }
   
}
