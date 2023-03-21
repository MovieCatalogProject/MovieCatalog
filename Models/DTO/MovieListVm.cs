using Katalog.Models.Domain;

namespace Katalog.Models.DTO
{
    public class MovieListVm
    {
        public IQueryable<Movie> MovieList { get; set; }//IQueryable интърфейса позволява отлагането на изпълнението на заявки??
        //MovieList - списъка с филми, които искаме да покажем/представим в web апликацията
        public int PageSize { get; set; } //Свойство, казващо колко филма да има на една страница (5 в този случай)
        public int CurrentPage { get; set; }//Показва текущата страница, в която се намира потребителят
        public int TotalPages { get; set; }//Показва общия брой на страниците
        public string? Term { get; set; }//Ключова дума, която потребителят въвежда, за да филтрира филмите
    }
}
