namespace Sever.Dto.Actor
{
    public class ActorDto : BaseDto
    {
        public int ActorId { get; set; }

        public string Name { get; set; }

        public DateTime DoB { get; set; }

        public string Nationality { get; set; }
    }
}
