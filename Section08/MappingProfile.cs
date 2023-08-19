using AutoMapper;
using Section08.DataAccess.Dto;
using Section08.Models;

namespace Section08;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
    }
}
