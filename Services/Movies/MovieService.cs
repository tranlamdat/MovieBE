using AutoMapper;
using Sever.Dto.Actor;
using Sever.Dto.Movie;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Actors;
using Sever.Repository.Directors;
using Sever.Repository.Genres;
using Sever.Repository.Movies;

namespace Sever.Services.Movies
{
    public class MovieService : IMovieService
    {
        private readonly IMapper _mapper;
        private readonly IGenreRepository _genreRepository;
        private readonly IDirectorRepository _directorRepository;
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMapper mapper, IGenreRepository genreRepository, IDirectorRepository directorRepository, IMovieRepository movieRepository)
        {
            _mapper = mapper;
            _genreRepository = genreRepository;
            _directorRepository = directorRepository;
            _movieRepository = movieRepository;
        }

        public MovieDto AddMovie(CreateMovieDto createMovieDto)
        {
            Genre genre = _genreRepository.GetGenreById(createMovieDto.GenreId) ?? throw new NotFoundException("Genre does not exists");
            Director director = _directorRepository.GetDirectorById(createMovieDto.DirectorId) ?? throw new NotFoundException("Director does not exists");

            Movie movie = _mapper.Map<Movie>(createMovieDto);
            _movieRepository.CreateMovie(movie);

            movie.Genre = genre;
            movie.Director = director;

            return _mapper.Map<MovieDto>(movie);
        }

        public string DeleteMovie(int id)
        {
            Movie movie = _movieRepository.GetMovieById(id) ?? throw new NotFoundException("Movie does not exists");
            _movieRepository.DeleteMovie(movie);

            return "Delete successfully";
        }

        public List<MovieDto> GetAllMovie()
        {
            List<Movie> movies = _movieRepository.GetAllMovie();
            return _mapper.Map<List<MovieDto>>(movies);
        }

        public List<MovieDto> OpenThisWeek()
        {
            List<Movie> movies = _movieRepository.GetMoviesByWeek();
            return _mapper.Map<List<MovieDto>>(movies);
        }

        public List<MovieDto> ComingSoon()
        {
            List<Movie> movies = _movieRepository.GetMoviesComingSoon();
            return _mapper.Map<List<MovieDto>>(movies);
        }

        public List<MovieDto> RelatedMovie(int genreId)
        {
            List<Movie> movies = _movieRepository.GetMoviesRelatedByGenre(genreId);
            return _mapper.Map<List<MovieDto>>(movies);
        }

        public MovieDto GetMovieById(int id)
        {
            Movie movie = _movieRepository.GetMovieById(id) ?? throw new NotFoundException("Movie does not exists"); ;
            return _mapper.Map<MovieDto>(movie);
        }

        public MovieDto UpdateMovie(int id, UpdateMovieDto updateMovieDto)
        {
            _ = _movieRepository.GetMovieById(id) ?? throw new NotFoundException("Movie does not exists");
            Genre genre = _genreRepository.GetGenreById(updateMovieDto.GenreId) ?? throw new NotFoundException("Genre does not exists");
            Director director = _directorRepository.GetDirectorById(updateMovieDto.DirectorId) ?? throw new NotFoundException("Director does not exists");

            updateMovieDto.MovieId = id;

            Movie movie = _mapper.Map<Movie>(updateMovieDto);
            _movieRepository.UpdateMovie(movie);

            movie.Genre = genre;
            movie.Director = director;

            return _mapper.Map<MovieDto>(movie);
        }
    }
}
