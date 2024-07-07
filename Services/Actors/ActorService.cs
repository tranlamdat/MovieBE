using AutoMapper;
using CloudinaryDotNet.Actions;
using Sever.Constraints;
using Sever.Dto.Actor;
using Sever.Dto.MovieMedia;
using Sever.Dto.User;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Actors;
using Sever.Services.Cloudinaries;

namespace Sever.Services.Actors
{
    public class ActorService : IActorService
    {
        private readonly IMapper _mapper;
        private readonly IActorRepository _actorRepository;
        private readonly IClodinaryService _clodinaryService;

        public ActorService(IMapper mapper, IActorRepository actorRepository, IClodinaryService clodinaryService)
        {
            _mapper = mapper;
            _actorRepository = actorRepository;
            _clodinaryService = clodinaryService;
        }

        public async Task<ActorDto> AddActor(CreateActorDto createActorDto)
        {
            Actor actor = _mapper.Map<Actor>(createActorDto);

            // Save profile picture
            if (createActorDto.NewAvatar != null)
            {
                var result = await _clodinaryService.UploadImageAsync(createActorDto.NewAvatar, EFileType.ACTOR.ToString());
                if (result.Error != null) throw new InvalidException(result.Error.Message);

                actor.AvatarUrl = result.SecureUri.AbsoluteUri;
                actor.PublicId = result.PublicId;
            }

            _actorRepository.CreateActor(actor);

            return _mapper.Map<ActorDto>(actor);
        }

        public string DeleteActor(int id)
        {
            Actor actor = _actorRepository.GetActorById(id) ?? throw new NotFoundException("Actor does not exists");
            _actorRepository.DeleteActor(actor);

            return "Delete successfully";
        }

        public ActorDto GetActorById(int id)
        {
            Actor actor = _actorRepository.GetActorById(id) ?? throw new NotFoundException("Actor does not exists"); ;
            return _mapper.Map<ActorDto>(actor);
        }

        public List<ActorDto> GetAllActor()
        {
            List<Actor> actors = _actorRepository.GetAllActor();
            return _mapper.Map<List<ActorDto>>(actors);
        }

        public async Task<ActorDto> UpdateActor(int id, UpdateActorDto updateActorDto)
        {
            Actor actor = _actorRepository.GetActorById(id) ?? throw new NotFoundException("Actor does not exists");

            updateActorDto.ActorId = id;
            actor = _mapper.Map<Actor>(updateActorDto);

            // Save profile picture
            if (updateActorDto.NewAvatar != null)
            {
                var result = await _clodinaryService.UploadImageAsync(updateActorDto.NewAvatar, EFileType.ACTOR.ToString());
                if (result.Error != null) throw new InvalidException(result.Error.Message);

                actor.AvatarUrl = result.SecureUri.AbsoluteUri;
                actor.PublicId = result.PublicId;

                if (updateActorDto.PublicId != null && updateActorDto.PublicId != "")
                {
                    await _clodinaryService.DeleteMediaAsync(updateActorDto.PublicId);
                }
            }

            _actorRepository.UpdateActor(actor);

            return _mapper.Map<ActorDto>(actor);
        }
    }
}
