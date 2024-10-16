namespace Sever.Dto.Contact
{
    public class ContactDto : BaseDto
    {
        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }
    }
}
