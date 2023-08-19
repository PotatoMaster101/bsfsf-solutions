using Section08.DataAccess.Dto;

namespace Section08.DataAccess.Repositories;

public interface IUserRepository : IRepository<UserDto>, IDisposable, IAsyncDisposable
{
    Task<UserDto?> GetById(int id, CancellationToken cancellationToken = default);
}
