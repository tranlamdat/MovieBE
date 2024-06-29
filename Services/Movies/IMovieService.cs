using Sever.Dto.Actor;
using Sever.Dto.Movie;

namespace Sever.Services.Movies
{
    public interface IMovieService
    {
        MovieDto AddMovie(CreateMovieDto createMovieDto);
        MovieDto UpdateMovie(int id, UpdateMovieDto updateMovieDto);
        string DeleteMovie(int id);
        MovieDto GetMovieById(int id);
        List<MovieDto> GetAllMovie();
    }
}
