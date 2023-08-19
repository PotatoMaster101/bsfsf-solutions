using Microsoft.EntityFrameworkCore;
using Section08.DataAccess.Dto;

namespace Section08.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<UserDto> Get()
    {
        return _dbContext.Users.AsQueryable();
    }

    public Task<UserDto?> GetById(int id, CancellationToken cancellationToken = default)
    {
        return _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<UserDto> Add(UserDto entity, CancellationToken cancellationToken = default)
    {
        var result = await _dbContext.AddAsync(entity, cancellationToken).ConfigureAwait(false);
        return result.Entity;
    }

    public Task<UserDto> Delete(UserDto entity, CancellationToken cancellationToken = default)
    {
        var result = _dbContext.Remove(entity);
        return Task.FromResult(result.Entity);
    }

    public Task Update(UserDto entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        return Task.CompletedTask;
    }

    public Task<int> UpdateAndSave(UserDto entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        return _dbContext.SaveChangesAsync(cancellationToken);
    }

    public Task<int> Save(CancellationToken cancellationToken = default)
    {
        return _dbContext.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        _dbContext.Dispose();
    }

    public ValueTask DisposeAsync()
    {
        GC.SuppressFinalize(this);
        return _dbContext.DisposeAsync();
    }
}
