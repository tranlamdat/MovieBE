using Microsoft.AspNetCore.Mvc;
using Sever.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchListController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public WatchListController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<WatchListController>
        [HttpGet]
        public ActionResult<IEnumerable<WatchList>> Get()//get all
        {
            return _context.WatchLists.ToList();
        }

        // GET api/<WatchListController>/5
        [HttpGet("{id}")]
        public ActionResult<WatchList> Get(int id)// get by id
        {
            return _context.WatchLists.Find(id);
        }

        // POST api/<WatchListController>
        [HttpPost]
        public IActionResult Post([FromBody] WatchList obj)// use to add data
        {
            if (ModelState.IsValid)
            {
                _context.WatchLists.Add(obj);


                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // PUT api/<WatchListController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WatchList obj)
        {
            WatchList watchList = _context.WatchLists.Find(id);//get obj by id
            if (watchList == null) { return BadRequest(); }
            if (ModelState.IsValid)
            {
                _context.WatchLists.Update(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE api/<WatchListController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            WatchList watchList = _context.WatchLists.Find(id);
            if (watchList == null) { return BadRequest(); }
            _context.WatchLists.Remove(watchList);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

