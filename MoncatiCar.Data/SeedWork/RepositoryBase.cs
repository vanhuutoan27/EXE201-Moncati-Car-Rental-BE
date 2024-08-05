using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.SeedWorks;
using System.Linq.Expressions;

namespace MoncatiCar.Data.SeedWork
{
    public class RepositoryBase<T, Key> : IRepositoryBase<T, Key> where T : class
    {
        private readonly DbSet<T> _dbSet;
        protected readonly MocatiContext _context;
        public RepositoryBase(MocatiContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }
        public void Add(T entity)
        {
            _dbSet.AddAsync(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T> GetByIdAsync(Key id)
        {
            return await _dbSet.FindAsync(id);
        }
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

    }
}
