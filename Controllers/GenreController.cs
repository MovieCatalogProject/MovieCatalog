using Katalog.Models.Domain;
using Katalog.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Katalog.Controllers
{
    [Authorize] // Необходимо е удостоверение, за да се получи достъп до методите в контролера 
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService; //IGenreService - интърфейс зададен в "Abstract"
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        public IActionResult Add() //Get method - използван за показване на "формуляр" на потребителя за създаване на нов жанр.
        {
            return View();
        }

        [HttpPost] //само за POST requests -изпращане на данни
        public IActionResult Add(Genre model) //Добавя жанр към базата данни : получава създадения обект от първия Add method 
            // и проверява дали той е валиден чрез ModelState
        {
            if (!ModelState.IsValid) 
                return View(model);
            var result = _genreService.Add(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }
        }

        public IActionResult Edit(int id) // Чрез методът редактираме жанр
        {
            var data = _genreService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Genre model) //Методът получава ъпдейтнат жанр и се опитва да обнови съответния обект в базата данни.
            
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = _genreService.Update(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(GenreList)); //След успешно ъпдейтване, потребителят се изпраща обратно в списъка с жанрове
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }
        }

        public IActionResult GenreList() // връща всички жанрове от базата данни, използвайки "_genreService"
        {
            var data = this._genreService.List().ToList();
            return View(data);
        }

        public IActionResult Delete(int id) //Изтрива жанрове от базата данни
        {
            var result = _genreService.Delete(id);
            return RedirectToAction(nameof(GenreList));
        }
    }
}
