namespace UniversityManagmentSystem.Interfaces
{
    public interface IFacultyCampusRepository : IBaseRepository<Models.FacultyCampus>
    {
        public void Save();
    }
}
