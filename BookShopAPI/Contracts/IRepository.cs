namespace BookShop.Contracts;

public interface IRepository<TEntity, TId> where TEntity : IKey
{
    bool Create(TEntity entity);    
    bool Update(TEntity entity);
    bool Delete(TEntity entity);
    IQueryable<TEntity> GetAll();
    TEntity? GetById(TId key);
}