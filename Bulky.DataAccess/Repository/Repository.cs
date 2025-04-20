using System.Linq.Expressions;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            if (filter is null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault(filter)!;
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Remove(int id)
        {
            var entityToDelete = dbSet.Find(id);

            if (entityToDelete is null)
            {
                throw new ArgumentNullException(nameof(entityToDelete));
            }

            dbSet.Remove(entityToDelete);
        }
        public void Remove(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            dbSet.RemoveRange(entity);
        }
    }
}
