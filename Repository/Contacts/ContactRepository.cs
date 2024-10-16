using Sever.Models;

namespace Sever.Repository.Contacts
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateContact(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating contact");
            }
        }
    }
}
