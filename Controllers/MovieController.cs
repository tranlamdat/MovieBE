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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
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

        /*[HttpPost("add-photo")]
        public async Task<ActionResult<MovieMediaDto>> AddPhoto(IFormFile formFile, int movieId)
        {
            var result = await _clodinaryService.UploadImageAsync(formFile, "image");

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

        [HttpPost("add-video")]
        public async Task<ActionResult<MovieMediaDto>> AddVideo(IFormFile formFile, int movieId)
        {
            var result = await _clodinaryService.UploadVideoAsync(formFile, "video");

            if (result.Error != null) return BadRequest(result.Error.Message);

            var movieMedia = new MovieMedia
            {
                Name = result.OriginalFilename,
                Url = result.SecureUri.AbsoluteUri,
                PublicId = result.PublicId,
                Type = Constraints.EFileType.VIDEO,
                MovieId = movieId
            };

            _context.MoviesMedias.Add(movieMedia);
            _context.SaveChanges();

            return _mapper.Map<MovieMediaDto>(movieMedia);
        }*/
    }
}

