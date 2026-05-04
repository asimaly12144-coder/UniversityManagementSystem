namespace UniversityManagmentSystem.Repositories
{
    public class StructureUnitRepository : BaseRepository<Models.StructureUnit>, Interfaces.IStructureUnitRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public StructureUnitRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
