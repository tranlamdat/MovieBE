using Sever.Dto.Actor;
using Sever.Dto.Genre;

namespace Sever.Services.Genres
{
    public interface IGenreService
    {
        GenreDto AddGenre(CreateGenreDto createGenreDto);
        GenreDto UpdateGenre(int id, UpdateGenreDto updateGenreDto);
        string DeleteGenre(int id);
        GenreDto GetGenreById(int id);
        List<GenreDto> GetAllGenre();
    }
}
