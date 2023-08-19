using Section06.Models;

namespace Section06.Services;

public class MilkshakeTypeRepository : IMilkshakeTypeRepository
{
    public Task<MilkshakeType[]> GetAll()
    {
        return Task.FromResult(new[]
        {
            new MilkshakeType(Guid.NewGuid(), "Vanilla"),
            new MilkshakeType(Guid.NewGuid(), "Chocolate"),
            new MilkshakeType(Guid.NewGuid(), "Banana")
        });
    }
}
