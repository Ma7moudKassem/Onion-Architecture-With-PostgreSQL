namespace ServicesAbstractions;

public interface IBaseService<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> GetAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

    Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task AddBulkAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

    Task EditAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task RemoveAsync(Guid id, CancellationToken cancellationToken = default);
    Task RemoveAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task RemoveBulkAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
}