using Sever.Models;

namespace Sever.Repository.Contacts
{
    public interface IContactRepository
    {
        void CreateContact(Contact contact);
    }
}
