using Microsoft.AspNetCore.Mvc;
using Sever.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GenresController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<GenresController>
        [HttpGet]
        public ActionResult<IEnumerable<Genre>> Get()//lay tat ca
        {
            return _context.Genres.ToList();
        }

        // GET api/<GenresController>/5
        [HttpGet("{id}")]
        public ActionResult<Genre> Get(int id)// lay theo id
        {
            return _context.Genres.Find(id);
        }

        // POST api/<GenresController>
        [HttpPost]
        public  IActionResult Post([FromBody] Genre obj)// dung' de them du lieu
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Add(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // PUT api/<GenresController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Genre obj)
        {
            Genre genre = _context.Genres.Find(id);//lay obj dua theo id
            if (genre == null) { return BadRequest(); }
            if (ModelState.IsValid)
            {

                genre.Name = obj.Name;
                _context.Genres.Update(genre);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Genre genre = _context.Genres.Find(id);
            if(genre == null) { return BadRequest(); }
            _context.Genres.Remove(genre);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
