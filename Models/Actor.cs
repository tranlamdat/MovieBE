using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sever.Models
{
    public class Actor : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActorId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime DoB { get; set; }

        [Required]
        public string Nationality { get; set; }

        public virtual ICollection<MovieActor>? MovieActors { get; set; }
    }
}
