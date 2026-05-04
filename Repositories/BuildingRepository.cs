namespace UniversityManagmentSystem.Repositories
{
    public class BuildingRepository : BaseRepository<Models.Building>, Interfaces.IBuildingRepository
    {
        private readonly Data.UniDbContext _mVC_Db_Context;
        public BuildingRepository(Data.UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
