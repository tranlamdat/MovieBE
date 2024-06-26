using AutoMapper;
using Sever.Dto.Actor;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Actors;

namespace Sever.Services.Actors
{
    public class ActorService : IActorService
    {
        private readonly IMapper _mapper;
        private readonly IActorRepository _actorRepository;

        public ActorService(IMapper mapper, IActorRepository actorRepository)
        {
            _mapper = mapper;
            _actorRepository = actorRepository;
        }

        public ActorDto AddActor(CreateActorDto createActorDto)
        {
            Actor actor = _mapper.Map<Actor>(createActorDto);
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

        public ActorDto UpdateActor(int id, UpdateActorDto updateActorDto)
        {
            _ = _actorRepository.GetActorById(id) ?? throw new NotFoundException("Actor does not exists");

            updateActorDto.ActorId = id;

            Actor actor = _mapper.Map<Actor>(updateActorDto);
            _actorRepository.UpdateActor(actor);

            return _mapper.Map<ActorDto>(actor);
        }
    }
}
