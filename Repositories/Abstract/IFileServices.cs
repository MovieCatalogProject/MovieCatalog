namespace Katalog.Repositories.Abstract
{
    public interface IFileServices
    {
        public Tuple<int, string> SaveImage(IFormFile imageFile);// Tuple има две стойности : 1. int - представлява статус код, който
        //информира дали операцията е била успешна или не; 2. string - предоставя допълнителна информация относно операцията (съобщение)
        public bool DeleteImage(string imageFileName); //Методът казва дали снимката е била успешно изтрита
    }
}
