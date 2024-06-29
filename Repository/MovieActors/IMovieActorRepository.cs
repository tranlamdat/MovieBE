using Sever.Models;

namespace Sever.Repository.MovieActors
{
    public interface IMovieActorRepository
    {
        void CreateMovieActor(MovieActor movieActor);
        MovieActor GetMovieActorById(int id);
        void UpdateMovieActor(MovieActor movieActor);
        void DeleteMovieActor(MovieActor movieActor);
        List<MovieActor> GetAllMovieActor();
    }
}
