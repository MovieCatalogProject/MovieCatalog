namespace Katalog.Models.Domain
{
    public class MovieGenre //Създава таблица в базата данни, комбинираща Id-тата на Movie и Genre (many-to-many)
    {
        public int id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
