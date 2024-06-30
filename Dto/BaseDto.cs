namespace Sever.Dto
{
    public class BaseDto
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
