using Sever.Models;

namespace Sever.Repository.Actors
{
    public interface IActorRepository
    {
        void CreateActor(Actor actor);
        Actor GetActorById(int id);
        void UpdateActor(Actor actor);
        void DeleteActor(Actor actor);
        List<Actor> GetAllActor();
        List<Actor> SearchActor(string actorName);
    }
}
