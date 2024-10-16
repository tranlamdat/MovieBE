﻿using AutoMapper;
using Sever.Models;
using Sever.Dto.Auth;
using Sever.Dto.Role;
using Sever.Dto.User;
using Sever.Dto.Actor;
using Sever.Dto.MovieMedia;
using Sever.Dto.Genre;
using Sever.Dto.Director;
using Sever.Dto.Movie;
using Sever.Dto.MovieActor;
using Sever.Dto.WatchList;
using Sever.Dto.Contact;

namespace Sever.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterDto, User>();
            
            CreateMap<Role, RoleDto>();
            CreateMap<User, UserDto>();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();

            CreateMap<CreateActorDto, Actor>();
            CreateMap<UpdateActorDto, Actor>();
            CreateMap<Actor, ActorDto>();

            CreateMap<CreateGenreDto, Genre>();
            CreateMap<UpdateGenreDto, Genre>();
            CreateMap<Genre, GenreDto>();

            CreateMap<CreateDirectorDto, Director>();
            CreateMap<UpdateDirectorDto, Director>();
            CreateMap<Director, DirectorDto>();

            CreateMap<CreateMovieDto, Movie>();
            CreateMap<UpdateMovieDto, Movie>();
            CreateMap<Movie, MovieDto>();

            CreateMap<CreateContactDto, Contact>();
            /*CreateMap<UpdateActorDto, Actor>();*/
            CreateMap<Contact, ContactDto>();

            CreateMap<CreateMovieActorDto, MovieActor>();
            CreateMap<UpdateMovieActorDto, MovieActor>();
            CreateMap<MovieActor, MovieActorDto>();

            CreateMap<MovieMedia, MovieMediaDto>();

            CreateMap<CreateWatchListDto, WatchList>();
            CreateMap<WatchList, WatchListDto>();
        }
    }
}
