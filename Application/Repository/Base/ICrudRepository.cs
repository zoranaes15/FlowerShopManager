using Application.Domain;

namespace Application.Repository.Base
{
    public interface ICrudRepository<TEntity> where TEntity : Entity
    {
        TEntity? Get(int id);
        List<TEntity> GetAll();
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
    }
}
