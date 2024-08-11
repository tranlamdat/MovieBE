using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sever.Dto.User;
using Sever.Dto;
using Sever.Exceptions;
using Sever.Models;
using Sever.Dto.WatchList;
using Sever.Services.WatchLists;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sever.Controllers
{
    // [Authorize(Roles = "Member")]
    [Route("api/watch-lists")]
    [ApiController]
    public class WatchListsController : ControllerBase
    {
        private readonly IWatchListService _watchListService;

        public WatchListsController(IWatchListService watchListService)
        {
            _watchListService = watchListService;
        }

        [HttpGet("{userId}/user")]
        public IActionResult Get(int userId)// get by id
        {
            ResponseDto response = new();
            try
            {
                List<WatchListDto> watchListDto = _watchListService.GetAllWatchListByUserId(userId);
                return Ok(watchListDto);
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

        // POST api/<WatchListController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateWatchListDto createWatchListDto)// use to add data
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                WatchListDto watchListDto = _watchListService.AddWatchList(createWatchListDto);
                return Ok(watchListDto);
            }
            catch (ConflictException e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status409Conflict, response);
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

        // DELETE api/<WatchListController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ResponseDto response = new();
            try
            {
                response.Message = _watchListService.DeleteWatchList(id);
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

