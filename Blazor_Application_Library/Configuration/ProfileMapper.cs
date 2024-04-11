using AutoMapper;
using Blazor_Application_Library.Models.Security;
using Blazor_Domain_Library.Entities.Security;

namespace Blazor_Application_Library.Configuration
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<UserEntity,UserDTO>().ReverseMap();
        }
    }
}
