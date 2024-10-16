using Sever.Dto.Contact;

namespace Sever.Services.Contacts
{
    public interface IContactService
    {
        ContactDto AddContact(CreateContactDto createContactDto);
    }
}
