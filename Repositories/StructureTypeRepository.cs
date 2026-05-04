using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class StructureTypeRepository : BaseRepository<Models.StructureType> , IStructureTypeRepository
    {
        private readonly UniDbContext _mVC_Db_Context;
        public StructureTypeRepository(UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
}
