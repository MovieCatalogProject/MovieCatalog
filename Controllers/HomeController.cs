using Katalog.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Katalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService; //IMovieService - интърфейс от "Abstract"
        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index(string term = "", int currentPage = 1) //Методът се вика, когато потребителят е в "home page-a". 
            //Използа интърфейса "IMovieservice", за да получи списък с филми въз основа на въведената дума за търсене (term) и номера
            // на текущата страница (currentPage).
        {
            var movies = _movieService.List(term, true, currentPage);
            return View(movies); //Извежда се филма
        }

        public IActionResult About() //About страницата на сайта.
        {
            return View();
        }

        public IActionResult MovieDetail(int movieId) //Методът се вика, когато потребителят натисне върху филм, за да види подробностите му.
            //Използва параметърът movieId и IMovieService интерфейса, за да вземе детайлите/подробностите на филма със съответното id.
        {
            var movie = _movieService.GetById(movieId);
            return View(movie);
        }
    }
}
