    using Microsoft.EntityFrameworkCore;
    using UniversityManagmentSystem.Data;
    using UniversityManagmentSystem.Interfaces;
    using System.Linq.Expressions;

    namespace UniversityManagmentSystem.Repositories
    {
        public class BaseRepository<T> : IBaseRepository<T> where T : class
        {
            private readonly UniDbContext _mVC_Db_Context;
            internal DbSet<T> dbSet;
            public BaseRepository(UniDbContext mVC_Db_Context)
            {
                _mVC_Db_Context = mVC_Db_Context;
                this.dbSet = _mVC_Db_Context.Set<T>();
            }

            public async Task<T> Add(T entity)
            {
                var result = await dbSet.AddAsync(entity);
                return result.Entity;
            }

            public T Get(Expression<Func<T, bool>> filter)
            {
                IQueryable<T> query = dbSet;
                query = query.Where(filter);
                return query.FirstOrDefault();
            }
            public IEnumerable<T> GetAll()
            {
                IQueryable<T> query = dbSet;
                return query.ToList();
            }
            public void Remove(T entity)
            {
                dbSet.Remove(entity);
            }
            public void Update(T entity)
            {
                dbSet.Attach(entity);
                _mVC_Db_Context.Entry(entity).State = EntityState.Modified;
            }
        }
    }
