using Katalog.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Katalog.Models.DTO;
using System.ComponentModel.DataAnnotations;


namespace Katalog.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthenticationService authService;
        public UserAuthenticationController(IUserAuthenticationService authService)
        {
            this.authService = authService;
        }
        
        //Създаваме потребител с админски права и го коментираме, защото ни трябва само един потребител с такива права.

        //public async Task<IActionResult> Register()
        //{
        //    var model = new RegistrationModel
        //    {
        //        Email = "admin@gmail.com",
        //        Username = "Admin",
        //        Name = "Svilen",
        //        Password = "Admin@123",
        //        PasswordConfirm = "Admin@123",
        //        Role = "Admin",
        //    };

        //    //Ако трябва да се регистрираме като обикновен потребител, да се промени ??Role="User"??

        //    var result = await authService.RegisterAsync(model);
        //    return Ok(result.Message);
        //}

        public async Task<IActionResult> Login()//връща празно view, където потребителят си въвежда данните
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model) //Методът взима въведените от потребителя данни, проверява дали са
            //валидни и ако да го изпраща в home страницата
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await authService.LoginAsync(model);

            if (result.StatusCode ==1)
                return RedirectToAction("Index","Home");

            else
            {
                TempData["msg"] = "Could not log in...";
                return RedirectToAction(nameof(Login));
            }
        }

        public async Task<IActionResult> Logout() //Изкарва потребителя от сайта и го изпраща в login страницата
        {
            await authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }

    }
}
