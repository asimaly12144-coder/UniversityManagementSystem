namespace UniversityManagmentSystem.Interfaces
{
    public interface IStructureUnitRepository : IBaseRepository<Models.StructureUnit>
    {
        public void Save();
    }
    
}
