using Microsoft.AspNetCore.Mvc;
using Sever.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DirectorController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<DirectorController>
        [HttpGet]
        public ActionResult<IEnumerable<Director>> Get()//lay tat ca
        {
            return _context.Directors.ToList();
        }

        // GET api/<DirectorController>/5
        [HttpGet("{id}")]
        public ActionResult<Director> Get(int id)// lay theo id
        {
            return _context.Directors.Find(id);
        }

        // POST api/<DirectorController>
        [HttpPost]
        public IActionResult Post([FromBody] Director obj)// dung' de them du lieu
        {
            if (ModelState.IsValid)
            {
                _context.Directors.Add(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // PUT api/<DirectorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Director obj)
        {
            Director director = _context.Directors.Find(id);//lay obj dua theo id
            if (director == null) { return BadRequest(); }
            if (ModelState.IsValid)
            {
                director.Name = obj.Name;
                director.DoB = obj.DoB;
                director.Nationality = obj.Nationality;
                _context.Directors.Update(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE api/<DirectorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Director director = _context.Directors.Find(id);
            if (director == null) { return BadRequest(); }
            _context.Directors.Remove(director);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
