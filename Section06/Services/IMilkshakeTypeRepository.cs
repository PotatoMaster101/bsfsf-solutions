using Section06.Models;

namespace Section06.Services;

public interface IMilkshakeTypeRepository
{
    Task<MilkshakeType[]> GetAll();
}
