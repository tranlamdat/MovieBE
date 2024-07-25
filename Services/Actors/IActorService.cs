using Sever.Dto.Actor;

namespace Sever.Services.Actors
{
    public interface IActorService
    {
        Task<ActorDto> AddActor(CreateActorDto createActorDto);
        Task<ActorDto> UpdateActor(int id, UpdateActorDto updateActorDto);
        string DeleteActor(int id);
        ActorDto GetActorById(int id);
        List<ActorDto> GetAllActor();
        List<ActorDto> SearchActor(string actorName);
    }
}
