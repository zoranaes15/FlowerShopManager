using Application.Domain;

namespace Application.Repository.Base
{
    public interface ICrudRepository<TEntity> where TEntity : Entity
    {
        TEntity? Get(int id);
        List<Entity> GetAll();
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
    }
}
