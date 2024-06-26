using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sever.Dto.MovieMedia;
using Sever.Models;
using Sever.Services.Cloudinaries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IClodinaryService _clodinaryService;
        private readonly IMapper _mapper;

        public MovieController(ApplicationDbContext context, IClodinaryService clodinaryService, IMapper mapper)
        {
            _context = context;
            _clodinaryService = clodinaryService;
            _mapper = mapper;
        }
        // GET: api/<MovieController>
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()//lay tat ca
        {
            return _context.Movies.ToList();
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)// lay theo id
        {
            return _context.Movies.Find(id);
        }

        // POST api/<MovieController>
        [HttpPost]
        public IActionResult Post([FromBody] Movie obj)// dung' de them du lieu
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie obj)
        {
            Movie movie = _context.Movies.Find(id);//lay obj dua theo id
            if (movie == null) { return BadRequest(); }
            if (ModelState.IsValid)
            {
                movie.Title = obj.Title;
                movie.ReleaseDate = obj.ReleaseDate;
                movie.Description = obj.Description;
                movie.Duration = obj.Duration;
                movie.National = obj.National;
                _context.Movies.Update(obj);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Movie movie = _context.Movies.Find(id);
            if (movie == null) { return BadRequest(); }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPost("add-photo")]
        public async Task<ActionResult<MovieMediaDto>> AddPhoto(IFormFile formFile, int movieId)
        {
            var result = await _clodinaryService.UploadImageAsync(formFile);

            if (result.Error != null) return BadRequest(result.Error.Message);

            var movieMedia = new MovieMedia
            {
                Name = result.OriginalFilename,
                Url = result.SecureUri.AbsoluteUri,
                PublicId = result.PublicId,
                Type = Constraints.EFileType.POSTER,
                MovieId = movieId
            };

            _context.MoviesMedias.Add(movieMedia);
            _context.SaveChanges();

            return _mapper.Map<MovieMediaDto>(movieMedia);
        }
    }
}

