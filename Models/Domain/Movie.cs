using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Katalog.Models.Domain
{
    public class Movie
    {
        
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? ReleaseYear { get; set; }

        public string? MovieImage { get; set; }  //запазваме името на снимката с extension (image001.jpg ; ...)
        [Required]
        public string? Cast { get; set; }
        [Required]
        public string? Director { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        [NotMapped]
        [Required]
        public List<int>? Genres { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? GenreList { get; set; }
        [NotMapped]
        public string? GenreNames { get; set; }

        [NotMapped]
        public MultiSelectList? MultiGenreList { get; set; }
    }
}
