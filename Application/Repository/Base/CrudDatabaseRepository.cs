using Application.Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository.Base
{
    public class CrudDatabaseRepository<TEntity, TDbContext> : ICrudRepository<TEntity>
        where TEntity : Entity
        where TDbContext : DbContext
    {
        protected readonly TDbContext DbContext;
        private readonly DbSet<TEntity> _dbSet;

        public CrudDatabaseRepository(TDbContext dbContext)
        {
            DbContext = dbContext;
            _dbSet = DbContext.Set<TEntity>();
        }

        public TEntity? Get(int id)
        {
            return _dbSet.AsNoTracking()
                 .FirstOrDefault(e => e.Id == id);
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList<TEntity>();
        }

        public TEntity Create(TEntity entity)
        {
            _dbSet.Add(entity);


            foreach (var entry in DbContext.ChangeTracker.Entries<Entity>().Where(e => e.Entity != entity && e.Entity.Id > 0))
            {
                entry.State = EntityState.Unchanged;
            }

            DbContext.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbSet.Update(entity);
            DbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                DbContext.SaveChanges();
            }
        }
    }
}
