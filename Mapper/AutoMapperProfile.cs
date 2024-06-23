using AutoMapper;
using Sever.Models;
using Sever.Dto.Auth;
using Sever.Dto.Role;
using Sever.Dto.User;

namespace Sever.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterDto, User>();

            /*CreateMap<FileDetails, FileDetailDto>();
            CreateMap<ImageDetails, ImageDetailDto>();*/
            CreateMap<Role, RoleDto>();
            CreateMap<User, UserDto>();
        }
    }
}
