using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Katalog.Models.Domain
{
    public class Movie // Класът създава таблицата Movie в базата данни
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

        [NotMapped] //Няма да се създава колона за този обект в таблицата
        public IFormFile? ImageFile { get; set; }
        [NotMapped]
        [Required]
        public List<int>? Genres { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? GenreList { get; set; } //свойство от тип IEnumerable<SelectListItem> (последователност от
               //избираеми обекти), използвано за показване на списък с жанрове в падащ списък във формуляра за филм.

        [NotMapped]
        public string? GenreNames { get; set; } //Свойство, използвано за съхранение на повече жанрове, разделени със запетая
               

        [NotMapped]
        public MultiSelectList? MultiGenreList { get; set; } //Свойство, използвано за показване на списък
               //с жанрове в падащ списък и може да се избират повече от един жанрове
        
    }
}
