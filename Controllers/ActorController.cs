using Microsoft.AspNetCore.Mvc;
using Sever.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ActorController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ActorController>
        [HttpGet]
        public ActionResult<IEnumerable<Actor>> Get()//lay tat ca
        {
            return _context.Actors.ToList();
        }

        // GET api/<ActorController>/5
        [HttpGet("{id}")]
        public ActionResult<Actor> Get(int id)// lay theo id
        {
            return _context.Actors.Find(id);
        }

        // POST api/<ActorController>
        [HttpPost]
        public IActionResult Post([FromBody] Actor obj)// dung' de them du lieu
        {
            if (ModelState.IsValid)
            {
                _context.Actors.Add(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // PUT api/<ActorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Actor obj)
        {
            Actor actor = _context.Actors.Find(id);//lay obj dua theo id
            if (actor == null) { return BadRequest(); }
            if (ModelState.IsValid)
            {
                actor.Name = obj.Name;
                actor.DoB = obj.DoB;
                actor.Nationality = obj.Nationality;
                _context.Actors.Update(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE api/<ActorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Actor actor = _context.Actors.Find(id);
            if (actor == null) { return BadRequest(); }
            _context.Actors.Remove(actor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

