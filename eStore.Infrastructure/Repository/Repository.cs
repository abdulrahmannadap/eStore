using System.Linq.Expressions;
using eStore.Application.common.Interfaces;
using eStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eStore.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal readonly DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbSet = db.Set<T>();
        }


        public void Add(T entity)
        {

            dbSet.Add(entity);
        }


        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties)
        {
            IQueryable<T> query = dbSet;

            query = query.Where(filter);
            if (includeProperties is not null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',', '-', '_' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

            }
            return query.FirstOrDefault()!;
        }
        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter, string? includeProperties)
        {
            IQueryable<T> query = dbSet;
            if (filter is not null)
            {
                query = query.Where(filter);
            }
            if (includeProperties is not null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',', '-', '_' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

            }
            return query.ToList();

        }
    }
}
