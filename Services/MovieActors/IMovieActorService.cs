using Sever.Dto.Movie;
using Sever.Dto.MovieActor;

namespace Sever.Services.MovieActors
{
    public interface IMovieActorService
    {
        MovieActorDto AddMovieActor(CreateMovieActorDto createMovieActorDto);
        MovieActorDto UpdateMovieActor(int id, UpdateMovieActorDto updateMovieActorDto);
        string DeleteMovieActor(int id);
        MovieActorDto GetMovieActorById(int id);
        List<MovieActorDto> GetAllMovieActor();
    }
}
