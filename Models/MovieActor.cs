using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sever.Models
{
    public class MovieActor : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieActorId { get; set; }

        public int MovieId { get; set; }

        public int ActorId { get; set; }

        public string CharacterName { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movie? Movie { get; set; }

        [ForeignKey("ActorId")]
        public virtual Actor? Actor { get; set; }
    }
}
