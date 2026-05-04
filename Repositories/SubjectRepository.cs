using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Repositories
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        private readonly UniDbContext _mVC_Db_Context;
        public SubjectRepository(UniDbContext mVC_Db_Context) : base(mVC_Db_Context)
        {
            _mVC_Db_Context = mVC_Db_Context;
        }
        public void Save()
        {
            _mVC_Db_Context.SaveChanges();
        }
    }
    
}
