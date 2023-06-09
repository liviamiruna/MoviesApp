using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter movie name")]
        public string GenreName { get; set; }

        public int ReleaseYear { get; set; }



    }
}
