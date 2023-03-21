using Katalog.Models.DTO;

namespace Katalog.Repositories.Abstract
{
    public interface IUserAuthenticationService 
    {
        Task<Status> LoginAsync(LoginModel model);//Взима LoginModel-а (DTO), който съдържа login информацията на потребителя
        //и връща Status съобщение, което показва дали "логването" е било успешно.

        Task LogoutAsync();//Методът изкарва потребителя от профила му

        Task<Status> RegisterAsync(RegistrationModel model); //Взима RegistrationModel-а (DTO), съдържащ информацията за регистрирането
        //на потребителя, и връща Status съобщение, което показва дали регистрирането е било успешно

    }
}
