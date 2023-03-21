using Microsoft.AspNetCore.Identity;

namespace Katalog.Models.Domain
{
    public class ApplicationUser : IdentityUser // Класа се използва за "представяне" на потребител 
        //IdentityUser - вграден клас в ASP.NET, който снабдява с основни данни за потребителя (Id, Email, PasswordHarsh)
    {
        public string Name { get; set; } //Name е в допълнение към IdentityUser данните
    }
}
