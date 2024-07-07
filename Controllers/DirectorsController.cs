using Microsoft.AspNetCore.Mvc;
using Sever.Dto.Actor;
using Sever.Dto;
using Sever.Models;
using Sever.Services.Actors;
using Sever.Services.Directors;
using Sever.Dto.Director;
using Sever.Exceptions;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/directors")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorService _directorService;

        public DirectorsController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        [HttpGet]
        public IActionResult Get()//lay tat ca
        {
            ResponseDto response = new();
            try
            {
                List<DirectorDto> directorDtos = _directorService.GetAllDirector();
                return Ok(directorDtos);
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
                DirectorDto directorDto = _directorService.GetDirectorById(id);
                return Ok(directorDto);
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
        public async Task<IActionResult> Post([FromForm] CreateDirectorDto createDirectorDto)// dung' de them du lieu
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                DirectorDto directorDto = await _directorService.AddDirector(createDirectorDto);
                return Ok(directorDto);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromForm] UpdateDirectorDto updateDirectorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                DirectorDto directorDto = await _directorService.UpdateDirector(id, updateDirectorDto);
                return Ok(directorDto);
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
                response.Message = _directorService.DeleteDirector(id);
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
