using AutoMapper;
using Sever.Dto.Actor;
using Sever.Dto.Genre;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Actors;
using Sever.Repository.Genres;

namespace Sever.Services.Genres
{
    public class GenreService : IGenreService
    {
        private readonly IMapper _mapper;
        private readonly IGenreRepository _genreRepository;

        public GenreService(IMapper mapper, IGenreRepository genreRepository)
        {
            _mapper = mapper;
            _genreRepository = genreRepository;
        }

        public GenreDto AddGenre(CreateGenreDto createGenreDto)
        {
            Genre genre = _mapper.Map<Genre>(createGenreDto);
            _genreRepository.CreateGenre(genre);

            return _mapper.Map<GenreDto>(genre);
        }

        public string DeleteGenre(int id)
        {
            Genre actor = _genreRepository.GetGenreById(id) ?? throw new NotFoundException("Genre does not exists");
            _genreRepository.DeleteGenre(actor);

            return "Delete successfully";
        }

        public List<GenreDto> GetAllGenre()
        {
            List<Genre> genres = _genreRepository.GetAllGenre();
            return _mapper.Map<List<GenreDto>>(genres);
        }

        public GenreDto GetGenreById(int id)
        {
            Genre genre = _genreRepository.GetGenreById(id) ?? throw new NotFoundException("Genre does not exists"); ;
            return _mapper.Map<GenreDto>(genre);
        }

        public GenreDto UpdateGenre(int id, UpdateGenreDto updateGenreDto)
        {
            _ = _genreRepository.GetGenreById(id) ?? throw new NotFoundException("Genre does not exists");

            updateGenreDto.GenreId = id;

            Genre genre = _mapper.Map<Genre>(updateGenreDto);
            _genreRepository.UpdateGenre(genre);

            return _mapper.Map<GenreDto>(genre);
        }
    }
}
