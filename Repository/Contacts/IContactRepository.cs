using Sever.Models;

namespace Sever.Repository.Contacts
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
        void CreateContact(Contact contact);
        Contact GetContactById(int id);
        void DeleteContact(Contact contact);
    }
}
