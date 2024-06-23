using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sever.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()//lay tat ca
        {
            List<User> user = _context.Users.ToList();

            if (user.Count == 0 || user[0].UserId <= 0)
            {
                return NotFound();
            }
            else
            {
                return user;
            }
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)// lay theo id
        {
            User user = _context.Users.Find(id); 

            if (user == null) { return NotFound();}
            else { return user; }
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User objUser)// dung' de them du lieu
        {
            if (objUser == null)
            {
                return BadRequest("User data is null.");
            }

            if (ModelState.IsValid)
            {
                _context.Users.Add(objUser);
                _context.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User objUser)
        {
            User foundUser = _context.Users.Find(id); //lay obj dua theo id

            if (foundUser == null) { return BadRequest(); }
            if (ModelState.IsValid)
            {                
                _context.Users.Update(objUser);
                _context.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            User user = _context.Users.Find(id);
            if (user == null) { return NotFound(); }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok();
        }
    }
}

