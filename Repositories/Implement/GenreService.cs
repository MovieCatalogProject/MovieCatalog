using Katalog.Models.Domain;
using Katalog.Repositories.Abstract;

namespace Katalog.Repositories.Implement
{
    public class GenreService : IGenreService
    {
        
        private readonly DatabaseContext ctx;
        public GenreService(DatabaseContext ctx)
        {
            this.ctx = ctx;
        }
        public bool Add(Genre model)//Методът приема обект Genre и го добавя към таблицата Genre в базата данни. Ако стане връща true, ако не - false
        {
            try
            {
                ctx.Genre.Add(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id) //Методът взима id-то на избрания жанр и изтрива съответния Genre обект от таблицата"Genre в базата данни. Ако стане връща true, ако не - false
        {
            try
            {
                var data = this.GetById(id);
                if (data == null)
                    return false;
                ctx.Genre.Remove(data);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Genre GetById(int id) //Взима id-то на даден жанр и връща съответстващия обект
        {
            return ctx.Genre.Find(id);
        }

        public IQueryable<Genre> List() //Връща всички Genre objects от Genre таблицата в базата данни
        {
            var data = ctx.Genre.AsQueryable();
            return data;
        }

        public bool Update(Genre model) //Методът взима дадения Genre object и го обновява в базата данни. Ако стане връща true, ако не - false
        {
            try
            {
                ctx.Genre.Update(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
