using Microsoft.EntityFrameworkCore;
using Sever.Models;

namespace Sever.Repository.Actors
{
    public class ActorRepository : IActorRepository
    {
        private readonly ApplicationDbContext _context;

        public ActorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateActor(Actor actor)
        {
            try
            {
                _context.Actors.Add(actor);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating actor");
            }
        }

        public void DeleteActor(Actor actor)
        {
            try
            {
                _context.Actors.Remove(actor);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting actor");
            }
        }

        public Actor GetActorById(int id)
        {
            try
            {
                return _context.Actors
                    .AsNoTracking()
                    .FirstOrDefault(u => u.ActorId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting actor");
            }
        }

        public List<Actor> GetAllActor()
        {
            try
            {
                return _context.Actors
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all user");
            }
        }

        public void UpdateActor(Actor actor)
        {
            try
            {
                _context.Entry<Actor>(actor).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating actor");
            }
        }
    }
}
