using AutoMapper;
using Sever.Dto.Contact;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Contacts;
using Sever.Repository.Directors;
using Sever.Services.Cloudinaries;

namespace Sever.Services.Contacts
{
    public class ContactService : IContactService
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public ContactService(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public ContactDto AddContact(CreateContactDto createContactDto)
        {
            Contact contact = _mapper.Map<Contact>(createContactDto);
            _contactRepository.CreateContact(contact);
            return _mapper.Map<ContactDto>(contact);
        }

        public string DeleteContact(int id)
        {
            Contact contact = _contactRepository.GetContactById(id) ?? throw new NotFoundException("Contact does not exists");
            _contactRepository.DeleteContact(contact);

            return "Delete successfully";
        }

        public List<ContactDto> GetAllContact()
        {
            List<Contact> contacts = _contactRepository.GetAll();
            return _mapper.Map<List<ContactDto>>(contacts);
        }
    }
}
