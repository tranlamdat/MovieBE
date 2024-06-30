using Microsoft.AspNetCore.Mvc;
using Sever.Dto.Movie;
using Sever.Dto;
using Sever.Models;
using Sever.Services.MovieActors;
using Sever.Services.Movies;
using Sever.Dto.MovieActor;
using Sever.Exceptions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/movie-actors")]
    [ApiController]
    public class MovieActorsController : ControllerBase
    {
        private readonly IMovieActorService _movieActorService;

        public MovieActorsController(IMovieActorService movieActorService)
        {
            _movieActorService = movieActorService;
        }

        [HttpGet]
        public IActionResult Get()//lay tat ca
        {
            ResponseDto response = new();
            try
            {
                List<MovieActorDto> movieActorDtos = _movieActorService.GetAllMovieActor();
                return Ok(movieActorDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)// lay theo id
        {
            ResponseDto response = new();
            try
            {
                MovieActorDto movieActorDto = _movieActorService.GetMovieActorById(id);
                return Ok(movieActorDto);
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

        [HttpPost]
        public IActionResult Post([FromBody] CreateMovieActorDto createMovieActorDto)// dung' de them du lieu
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                MovieActorDto movieActorDto = _movieActorService.AddMovieActor(createMovieActorDto);
                return Ok(movieActorDto);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateMovieActorDto updateMovieActorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                MovieActorDto movieActorDto = _movieActorService.UpdateMovieActor(id, updateMovieActorDto);
                return Ok(movieActorDto);
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
                response.Message = _movieActorService.DeleteMovieActor(id);
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

