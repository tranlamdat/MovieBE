using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sever.Dto.Actor;
using Sever.Dto;
using Sever.Dto.MovieMedia;
using Sever.Models;
using Sever.Services.Actors;
using Sever.Services.Cloudinaries;
using Sever.Services.Movies;
using Sever.Dto.Movie;
using Sever.Exceptions;
using Microsoft.AspNetCore.Authorization;

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
        public IActionResult Get()//lay tat ca
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

