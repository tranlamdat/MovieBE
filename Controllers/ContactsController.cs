using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sever.Dto.Actor;
using Sever.Dto;
using Sever.Dto.Contact;
using Sever.Services.Actors;
using Sever.Services.Contacts;
using Sever.Exceptions;

namespace Sever.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Get() //lay tat ca
        {
            ResponseDto response = new();
            try
            {
                List<ContactDto> contactDtos = _contactService.GetAllContact();
                return Ok(contactDtos);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody] CreateContactDto createContactDto) // dung' de them du lieu
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseDto response = new();
            try
            {
                ContactDto contactDto = _contactService.AddContact(createContactDto);
                return Ok(contactDto);
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
                response.Message = _contactService.DeleteContact(id);
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
