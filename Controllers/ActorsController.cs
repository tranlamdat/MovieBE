using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sever.Dto;
using Sever.Dto.Actor;
using Sever.Exceptions;
using Sever.Models;
using Sever.Services.Actors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/actors")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IActorService _actorService;

        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpGet]
        public IActionResult Get() //lay tat ca
        {
            ResponseDto response = new();
            try
            {
                List<ActorDto> actorDtos = _actorService.GetAllActor();
                return Ok(actorDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) // lay theo id
        {
            ResponseDto response = new();
            try
            {
                ActorDto actorDto = _actorService.GetActorById(id);
                return Ok(actorDto);
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
        public IActionResult Post([FromBody] CreateActorDto createActorDto) // dung' de them du lieu
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                ActorDto actorDto = _actorService.AddActor(createActorDto);
                return Ok(actorDto);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateActorDto updateActorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                ActorDto actorDto = _actorService.UpdateActor(id, updateActorDto);
                return Ok(actorDto);
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
                response.Message = _actorService.DeleteActor(id);
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

