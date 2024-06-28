using Sever.Models;

namespace Sever.Repository.Genres
{
    public interface IGenreRepository
    {
        void CreateGenre(Genre genre);
        Genre GetGenreById(int id);
        void UpdateGenre(Genre genre);
        void DeleteGenre(Genre genre);
        List<Genre> GetAllGenre();
    }
}
