using AutoMapper;
using SSO.Domains;
using SSO.Models.DTOs;

namespace SSO.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserEntity, UserDTO>().ReverseMap();
            CreateMap<UserEntity, SignUpDTO>().ReverseMap();
            CreateMap<RoleEntity, RoleDTO>().ReverseMap();
            CreateMap<BlogEntity, BlogDTO>()
                .ForMember(x => x.User, x => x.MapFrom(x => x.UserEntity))
                .ReverseMap()
                //.ForMember(x => x.UserEntity, x => x.MapFrom(x => x.User))
                ;
        }
    }
}
