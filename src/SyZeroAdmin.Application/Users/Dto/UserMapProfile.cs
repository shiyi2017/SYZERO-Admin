using AutoMapper;
using SyZeroAdmin.Core.Authorization.Users;

namespace SyZeroAdmin.Application.Users.Dto
{
    public class UserMapProfile : Profile
    {
        public UserMapProfile()
        {
            CreateMap<UserDto, User>();
        }
            
    }
}
