namespace Katalog.Models.Domain
{
    public class MovieGenre //комбинира Movie и Genre
    {
        public int id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
