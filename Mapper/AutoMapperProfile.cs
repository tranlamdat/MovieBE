using AutoMapper;
using Sever.Models;
using Sever.Dto.Auth;
using Sever.Dto.Role;
using Sever.Dto.User;
using Sever.Dto.Actor;
using Sever.Dto.MovieMedia;

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

            CreateMap<CreateActorDto, Actor>();
            CreateMap<UpdateActorDto, Actor>();
            CreateMap<Actor, ActorDto>();

            CreateMap<MovieMedia, MovieMediaDto>();
        }
    }
}
