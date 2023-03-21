using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Katalog.Models.DTO
{
    public class RegistrationModel //Клас, играещ ролята на модел за регистрация на даден потребител
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Minimum length 6 and must contain  1 Uppercase,1 lowercase, 1 special character and 1 digit")]
        //'^' - началото на низа
        //'(?=.*?[A-Z])' - изисква поне една главна буква
        //'(?=.*?[a-z])' - изисква поне една малка буква
        //'(?=.*?[0-9])' - изисква поне една цифра
        //'(?=.*[#$^+=!*()@%&])' - изисква поне един специален знак
        //'.{ 6,}' - трябва паролата да е поне 6 знака дълга
        //'$' - края на низа
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
        public string Role { get; set; }
    }
}
