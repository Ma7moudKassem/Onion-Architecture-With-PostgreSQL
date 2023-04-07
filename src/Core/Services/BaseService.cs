using Microsoft.EntityFrameworkCore.Storage;

namespace Services;

public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
{
    readonly IBaseRepository<TEntity> _repository;
    public BaseService(IBaseRepository<TEntity> repository) => _repository = repository;

    public async Task<IEnumerable<TEntity>> GetAsync(CancellationToken cancellationToken = default) => await _repository.GetAsync();

    public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default) =>
        await _repository.GetAsync(predicate);

    public Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        _repository.GetByIdAsync(id);

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        using IDbContextTransaction transaction = await _repository.GetTransactionAsync();
        try
        {
            if (entity is null)
                throw new ArgumentNullException(typeof(TEntity).Name);

            await _repository.AddAsync(entity);

            if (transaction is not null) await transaction.CommitAsync(cancellationToken);
        }
        catch (Exception exception)
        {
            if (transaction is not null) await transaction.RollbackAsync(cancellationToken);

            throw new Exception(exception.Message);
        }
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