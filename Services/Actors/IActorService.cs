using Sever.Dto.Actor;

namespace Sever.Services.Actors
{
    public interface IActorService
    {
        ActorDto AddActor(CreateActorDto createActorDto);
        ActorDto UpdateActor(int id, UpdateActorDto updateActorDto);
        string DeleteActor(int id);
        ActorDto GetActorById(int id);
        List<ActorDto> GetAllActor();
    }
}
