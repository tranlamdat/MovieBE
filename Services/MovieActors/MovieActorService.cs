using AutoMapper;
using Sever.Dto.Movie;
using Sever.Dto.MovieActor;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Actors;
using Sever.Repository.Directors;
using Sever.Repository.Genres;
using Sever.Repository.MovieActors;
using Sever.Repository.Movies;

namespace Sever.Services.MovieActors
{
    public class MovieActorService : IMovieActorService
    {
        private readonly IMapper _mapper;
        private readonly IMovieRepository _movieRepository;
        private readonly IActorRepository _actorRepository;
        private readonly IMovieActorRepository _movieActorRepository;

        public MovieActorService(IMapper mapper, IMovieRepository movieRepository, IActorRepository actorRepository, IMovieActorRepository movieActorRepository)
        {
            _mapper = mapper;
            _movieRepository = movieRepository;
            _actorRepository = actorRepository;
            _movieActorRepository = movieActorRepository;
        }

        public MovieActorDto AddMovieActor(CreateMovieActorDto createMovieActorDto)
        {
            Movie movie = _movieRepository.GetMovieById(createMovieActorDto.MovieId) ?? throw new NotFoundException("Movie does not exists");
            Actor actor = _actorRepository.GetActorById(createMovieActorDto.ActorId) ?? throw new NotFoundException("Actor does not exists");

            MovieActor movieActor = _mapper.Map<MovieActor>(createMovieActorDto);
            _movieActorRepository.CreateMovieActor(movieActor);

            movieActor.Movie = movie;
            movieActor.Actor = actor;

            return _mapper.Map<MovieActorDto>(movieActor);
        }

        public string DeleteMovieActor(int id)
        {
            MovieActor movieActor = _movieActorRepository.GetMovieActorById(id) ?? throw new NotFoundException("Movie actor does not exists");
            _movieActorRepository.DeleteMovieActor(movieActor);

            return "Delete successfully";
        }

        public List<MovieActorDto> GetAllMovieActor()
        {
            List<MovieActor> movieActors = _movieActorRepository.GetAllMovieActor();
            return _mapper.Map<List<MovieActorDto>>(movieActors);
        }

        public MovieActorDto GetMovieActorById(int id)
        {
            MovieActor movieActor = _movieActorRepository.GetMovieActorById(id) ?? throw new NotFoundException("Movie actor does not exists"); ;
            return _mapper.Map<MovieActorDto>(movieActor);
        }

        public MovieActorDto UpdateMovieActor(int id, UpdateMovieActorDto updateMovieActorDto)
        {
            _ = _movieActorRepository.GetMovieActorById(id) ?? throw new NotFoundException("Movie actor does not exists");
            Movie movie = _movieRepository.GetMovieById(updateMovieActorDto.MovieId) ?? throw new NotFoundException("Movie does not exists");
            Actor actor = _actorRepository.GetActorById(updateMovieActorDto.ActorId) ?? throw new NotFoundException("Actor does not exists");

            updateMovieActorDto.MovieActorId = id;

            MovieActor movieActor = _mapper.Map<MovieActor>(updateMovieActorDto);
            _movieActorRepository.UpdateMovieActor(movieActor);

            movieActor.Movie = movie;
            movieActor.Actor = actor;

            return _mapper.Map<MovieActorDto>(movieActor);
        }
    }
}
