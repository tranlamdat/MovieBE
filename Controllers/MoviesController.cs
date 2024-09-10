using Microsoft.AspNetCore.Mvc;
using Sever.Dto;
using Sever.Services.Movies;
using Sever.Dto.Movie;
using Sever.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Sever.Dto.Actor;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Get() //lay tat ca
        {
            ResponseDto response = new();
            try
            {
                List<MovieDto> movieDtos = _movieService.GetAllMovie();
                return Ok(movieDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [AllowAnonymous]
        [HttpGet("open-this-week")]
        public IActionResult OpenThisWeek()
        {
            ResponseDto response = new();
            try
            {
                List<MovieDto> movieDtos = _movieService.OpenThisWeek();
                return Ok(movieDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [AllowAnonymous]
        [HttpGet("coming-soon")]
        public IActionResult ComingSoon()
        {
            ResponseDto response = new();
            try
            {
                List<MovieDto> movieDtos = _movieService.ComingSoon();
                return Ok(movieDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [AllowAnonymous]
        [HttpGet("related/{genreId}")]
        public IActionResult RelatedMovie(int genreId)
        {
            ResponseDto response = new();
            try
            {
                List<MovieDto> movieDtos = _movieService.RelatedMovie(genreId);
                return Ok(movieDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public IActionResult Get(int id)// lay theo id
        {
            ResponseDto response = new();
            try
            {
                MovieDto movieDto = _movieService.GetMovieById(id);
                return Ok(movieDto);
            }
            catch (NotFoundException e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status404NotFound, response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [AllowAnonymous]
        [HttpGet("search")]
        public IActionResult Search(string name, string type)
        {
            ResponseDto response = new();
            try
            {
                List<MovieDto> movieDtos = _movieService.SearchMovie(name, type);
                return Ok(movieDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("top-most-view")]
        public IActionResult TopMostView(int top)
        {
            ResponseDto response = new();
            try
            {
                List<MovieDto> movieDtos = _movieService.TopMostView(top);
                return Ok(movieDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("top-movie-like")]
        public IActionResult TopMovieLike(int top)
        {
            ResponseDto response = new();
            try
            {
                List<MovieDto> movieDtos = _movieService.TopMovieLike(top);
                return Ok(movieDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [AllowAnonymous]
        [HttpPut("view/{id}")]
        public IActionResult UpdateView(int id)
        {
            ResponseDto response = new();
            try
            {
                response.Message = _movieService.UpdateView(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateMovieDto createMovieDto)// dung' de them du lieu
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                MovieDto movieDto = _movieService.AddMovie(createMovieDto);
                return Ok(movieDto);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateMovieDto updateMovieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                MovieDto movieDto = _movieService.UpdateMovie(id, updateMovieDto);
                return Ok(movieDto);
            }
            catch (NotFoundException e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status404NotFound, response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ResponseDto response = new();
            try
            {
                response.Message = _movieService.DeleteMovie(id);
                return Ok(response);
            }
            catch (NotFoundException e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status404NotFound, response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }
}

