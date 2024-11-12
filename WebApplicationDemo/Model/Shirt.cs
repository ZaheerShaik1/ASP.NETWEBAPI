using System.ComponentModel.DataAnnotations;
using WebApplicationDemo.Model.Validations;

namespace WebApplicationDemo.Model
{
    public class Shirt
    {
        public int ShirtId { get; set; }

        [Required]
        public string? Brand { get; set; }

        [Required]
        public string? Color { get; set; }

        [Shirt_EnsureCorrectSizing]
        public int Size { get; set; }

        public string? Gender { get; set; }

        public double Price { get; set; }
    }
}
