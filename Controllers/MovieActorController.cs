using Microsoft.AspNetCore.Mvc;
using Sever.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieActorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public MovieActorController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<MovieActorController>
        [HttpGet]
        public ActionResult<IEnumerable<MovieActor>> Get()//lay tat ca
        {
            return _context.MovieActors.ToList();
        }

        // GET api/<MovieActorController>/5
        [HttpGet("{id}")]
        public ActionResult<MovieActor> Get(int id)// lay theo id
        {
            return _context.MovieActors.Find(id);
        }

        // POST api/<MovieActorController>
        [HttpPost]
        public IActionResult Post([FromBody] MovieActor obj)// dung' de them du lieu
        {
            if (ModelState.IsValid)
            {
                _context.MovieActors.Add(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // PUT api/<MovieActorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MovieActor obj)
        {
            MovieActor movieActor = _context.MovieActors.Find(id);//lay obj dua theo id
            if (movieActor == null) { return BadRequest(); }
            if (ModelState.IsValid)
            {
                movieActor.CharacterName = obj.CharacterName;
                _context.MovieActors.Update(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE api/<MovieActorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            MovieActor movieActor = _context.MovieActors.Find(id);
            if (movieActor == null) { return BadRequest(); }
            _context.MovieActors.Remove(movieActor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

