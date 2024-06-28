using AutoMapper;
using Sever.Dto.Actor;
using Sever.Dto.Director;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Actors;
using Sever.Repository.Directors;

namespace Sever.Services.Directors
{
    public class DirectorService : IDirectorService
    {
        private readonly IMapper _mapper;
        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IMapper mapper, IDirectorRepository directorRepository)
        {
            _mapper = mapper;
            _directorRepository = directorRepository;
        }

        public DirectorDto AddDirector(CreateDirectorDto createDirectorDto)
        {
            Director director = _mapper.Map<Director>(createDirectorDto);
            _directorRepository.CreateDirector(director);

            return _mapper.Map<DirectorDto>(director);
        }

        public string DeleteDirector(int id)
        {
            Director director = _directorRepository.GetDirectorById(id) ?? throw new NotFoundException("Director does not exists");
            _directorRepository.DeleteDirector(director);

            return "Delete successfully";
        }

        public List<DirectorDto> GetAllDirector()
        {
            List<Director> directors = _directorRepository.GetAllDirector();
            return _mapper.Map<List<DirectorDto>>(directors);
        }

        public DirectorDto GetDirectorById(int id)
        {
            Director director = _directorRepository.GetDirectorById(id) ?? throw new NotFoundException("Director does not exists"); ;
            return _mapper.Map<DirectorDto>(director);
        }

        public DirectorDto UpdateDirector(int id, UpdateDirectorDto updateDirectorDto)
        {
            _ = _directorRepository.GetDirectorById(id) ?? throw new NotFoundException("Director does not exists");

            updateDirectorDto.DirectorId = id;

            Director director = _mapper.Map<Director>(updateDirectorDto);
            _directorRepository.UpdateDirector(director);

            return _mapper.Map<DirectorDto>(director);
        }
    }
}
