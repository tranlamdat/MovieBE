using AutoMapper;
using Sever.Constraints;
using Sever.Dto.Actor;
using Sever.Dto.Director;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Directors;
using Sever.Services.Cloudinaries;

namespace Sever.Services.Directors
{
    public class DirectorService : IDirectorService
    {
        private readonly IMapper _mapper;
        private readonly IDirectorRepository _directorRepository;
        private readonly IClodinaryService _clodinaryService;

        public DirectorService(IMapper mapper, IDirectorRepository directorRepository, IClodinaryService clodinaryService)
        {
            _mapper = mapper;
            _directorRepository = directorRepository;
            _clodinaryService = clodinaryService;
        }

        public async Task<DirectorDto> AddDirector(CreateDirectorDto createDirectorDto)
        {
            Director director = _mapper.Map<Director>(createDirectorDto);

            // Save profile picture
            if (createDirectorDto.NewAvatar != null)
            {
                var result = await _clodinaryService.UploadImageAsync(createDirectorDto.NewAvatar, EFileType.DIRECTOR.ToString());
                if (result.Error != null) throw new InvalidException(result.Error.Message);

                director.AvatarUrl = result.SecureUri.AbsoluteUri;
                director.PublicId = result.PublicId;
            }

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

        public async Task<DirectorDto> UpdateDirector(int id, UpdateDirectorDto updateDirectorDto)
        {
            Director director = _directorRepository.GetDirectorById(id) ?? throw new NotFoundException("Director does not exists");

            updateDirectorDto.DirectorId = id;
            director = _mapper.Map<Director>(updateDirectorDto);

            // Save profile picture
            if (updateDirectorDto.NewAvatar != null)
            {
                var result = await _clodinaryService.UploadImageAsync(updateDirectorDto.NewAvatar, EFileType.DIRECTOR.ToString());
                if (result.Error != null) throw new InvalidException(result.Error.Message);

                director.AvatarUrl = result.SecureUri.AbsoluteUri;
                director.PublicId = result.PublicId;

                if (updateDirectorDto.PublicId != null && updateDirectorDto.PublicId != "")
                {
                    await _clodinaryService.DeleteMediaAsync(updateDirectorDto.PublicId);
                }
            }

            _directorRepository.UpdateDirector(director);

            return _mapper.Map<DirectorDto>(director);
        }
    }
}
