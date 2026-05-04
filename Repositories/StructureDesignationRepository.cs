namespace UniversityManagmentSystem.Repositories
{
    public class StructureDesignationRepository : BaseRepository<Models.StructureDesignation>, Interfaces.IStructureDesignationRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public StructureDesignationRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
   
}
