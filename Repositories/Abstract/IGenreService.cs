using Katalog.Controllers;
using Katalog.Models.Domain;
using Katalog.Models.DTO;

namespace Katalog.Repositories.Abstract
{
    public interface IGenreService
    {
        
        bool Add(Genre model);
        bool Update(Genre model);
        Genre GetById(int id);
        bool Delete(int id);
        IQueryable<Genre> List();
    }
}
