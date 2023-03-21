using Katalog.Controllers;
using Katalog.Models.Domain;
using Katalog.Models.DTO;

namespace Katalog.Repositories.Abstract
{
    public interface IGenreService //Управлява Genre обектите   
    {
        
        bool Add(Genre model); //Методът връща информация дали операцията относно добавяне на жанр в базата данни е била успешна
        bool Update(Genre model);//Проверява дали обновлението на даден жанр е било успешно
        Genre GetById(int id); // Този метод взема "номера" (int),
        // представляващ уникалния идентификатор на даден Genre обект, и връща съответния Genre обект.
        bool Delete(int id); //Взима id-то на даден жанр и го изтрива от базата данни
        IQueryable<Genre> List(); //Извлича списък на всички жанрове от базата данни и връща "IQueryable<Genre>" обект, който може да се 
        //използва за още заявки към базата данни ??
        //IQueryable - извлича информация от база данни
    }
}
