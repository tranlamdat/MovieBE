using Sever.Dto.Actor;
using Sever.Dto.Movie;

namespace Sever.Services.Movies
{
    public interface IMovieService
    {
        MovieDto AddMovie(CreateMovieDto createMovieDto);
        MovieDto UpdateMovie(int id, UpdateMovieDto updateMovieDto);
        string UpdateView(int id);
        string DeleteMovie(int id);
        MovieDto GetMovieById(int id);
        List<MovieDto> GetAllMovie();
        List<MovieDto> OpenThisWeek();
        List<MovieDto> ComingSoon();
        List<MovieDto> RelatedMovie(int genreId);
        List<MovieDto> SearchMovie(string name, string type);
        List<MovieDto> TopMostView(int top);
        List<MovieDto> TopMovieLike(int top);
    }
}
