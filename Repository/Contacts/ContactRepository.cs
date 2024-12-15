using Microsoft.EntityFrameworkCore;
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

        public void DeleteContact(Contact contact)
        {
            try
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting contact");
            }
        }

        public List<Contact> GetAll()
        {
            try
            {
                return _context.Contacts
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all conact");
            }
        }

        public Contact GetContactById(int id)
        {
            try
            {
                return _context.Contacts
                    .AsNoTracking()
                    .FirstOrDefault(u => u.ContactId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting contact");
            }
        }
    }
}
