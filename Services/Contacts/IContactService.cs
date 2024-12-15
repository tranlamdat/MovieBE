using Sever.Dto.Contact;

namespace Sever.Services.Contacts
{
    public interface IContactService
    {
        List<ContactDto> GetAllContact();
        ContactDto AddContact(CreateContactDto createContactDto);
        string DeleteContact(int id);
    }
}
