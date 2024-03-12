using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public abstract class Entitet
    {
        [Key]

        public int ID { get; set; }
    }
}
