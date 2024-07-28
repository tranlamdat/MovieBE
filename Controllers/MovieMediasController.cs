using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sever.Dto;
using Sever.Dto.Actor;
using Sever.Dto.MovieActor;
using Sever.Dto.MovieMedia;
using Sever.Exceptions;
using Sever.Services.MovieMedias;

namespace Sever.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/movie-medias")]
    [ApiController]
    public class MovieMediasController : ControllerBase
    {
        private readonly IMovieMediaService _movieMediaService;

        public MovieMediasController(IMovieMediaService movieMediaService)
        {
            _movieMediaService = movieMediaService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CreateMovieMediaDto createMovieMediaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                MovieMediaDto movieMediaDto = await _movieMediaService.AddMovieMedia(createMovieMediaDto);
                return Ok(movieMediaDto);
            }
            catch (ConflictException e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status409Conflict, response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromForm] CreateMovieMediaDto createMovieMediaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                MovieMediaDto movieMediaDto = await _movieMediaService.UpdateMovieMedia(id, createMovieMediaDto);
                return Ok(movieMediaDto);
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
        public async Task<IActionResult> DeleteMovieMedia(int id)
        {
            ResponseDto response = new();
            try
            {
                response.Message = await _movieMediaService.DeleteMovieMedia(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }
}
