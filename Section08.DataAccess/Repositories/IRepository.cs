namespace Section08.DataAccess.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    IQueryable<TEntity> Get();

    Task<TEntity> Add(TEntity entity, CancellationToken cancellationToken = default);

    Task<TEntity> Delete(TEntity entity, CancellationToken cancellationToken = default);

    Task Update(TEntity entity, CancellationToken cancellationToken = default);

    Task<int> UpdateAndSave(TEntity entity, CancellationToken cancellationToken = default);

    Task<int> Save(CancellationToken cancellationToken = default);
}
