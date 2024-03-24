using AutoMapper;
using SSO.Domains;
using SSO.Models.DTOs;

namespace SSO.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserEntity, UserDTO>();
        }
    }
}
