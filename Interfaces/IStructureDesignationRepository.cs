namespace UniversityManagmentSystem.Interfaces
{
    public interface IStructureDesignationRepository : IBaseRepository<Models.StructureDesignation>
    {
        public void Save();
    }
}
