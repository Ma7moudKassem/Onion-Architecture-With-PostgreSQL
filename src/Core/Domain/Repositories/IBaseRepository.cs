using Microsoft.EntityFrameworkCore.Storage;

namespace Domain;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetByIdAsync(Guid id);
    Task<IEnumerable<TEntity>> GetAsync();
    Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);

    Task AddAsync(TEntity entity);
    Task AddBulkAsync(IEnumerable<TEntity> entities);

    Task EditAsync(TEntity entity);

    Task RemoveAsync(Guid id);
    Task RemoveAsync(TEntity entity);
    Task RemoveBulkAsync(Expression<Func<TEntity, bool>> predicate);

    Task<IDbContextTransaction> GetTransactionAsync();
}