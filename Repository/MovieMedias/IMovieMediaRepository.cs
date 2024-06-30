using Sever.Models;

namespace Sever.Repository.MovieMedias
{
    public interface IMovieMediaRepository
    {
        void CreateMovieMedia(MovieMedia movieMedia);
        MovieMedia GetMovieMediaById(int id);
        List<MovieMedia> GetMovieMediaByMovieId(int movieId);
        void UpdateMovieMedia(MovieMedia movieMedia);
        void DeleteMovieMedia(MovieMedia movieMedia);
    }
}
