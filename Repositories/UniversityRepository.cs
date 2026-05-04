using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Repositories
{
    public class UniversityRepository : BaseRepository<University>, IUniversityRepository
    {
        private readonly UniDbContext _mVC_Db_Context;

        public UniversityRepository(UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }

    }
}
