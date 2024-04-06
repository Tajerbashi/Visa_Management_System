﻿using AutoMapper;
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
            CreateMap<BlogEntity, BlogDTO>().ReverseMap();
        }
    }
}