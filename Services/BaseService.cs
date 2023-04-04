namespace Services;

public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
{
    readonly IBaseRepository<TEntity> _repository;
    public BaseService(IBaseRepository<TEntity> repository) => _repository = repository;

    public async Task<IEnumerable<TEntity>> GetAsync(CancellationToken cancellationToken = default)
    {
        IEnumerable<TEntity> entities = await _repository.GetAsync();

        return entities;
    }

    public Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task AddBulkAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task EditAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task RemoveBulkAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}