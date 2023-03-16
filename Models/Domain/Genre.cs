using Microsoft.Build.Framework;

namespace Katalog.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required] //Не може да бъде празно
        public string GenreName { get; set; }
    }
}
