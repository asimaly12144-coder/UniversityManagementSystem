namespace UniversityManagmentSystem.Interfaces
{
    public  interface IFloorRepository : IBaseRepository<Models.Floor>
    {
        public void Save();
    }
}
