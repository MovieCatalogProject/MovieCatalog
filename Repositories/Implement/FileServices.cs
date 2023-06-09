using Katalog.Repositories.Abstract;

namespace Katalog.Repositories.Implementation
{
    public class FileServices : IFileServices //Класът позволява потребителите на качват и да изтриват снимки в сайта
    {
        private readonly IWebHostEnvironment environment;
        public FileServices(IWebHostEnvironment env)
        }
            this.environment = env;
        }

        public Tuple<int, string> SaveImage(IFormFile imageFile) //Методът взема файл с изображение и го записва в "Uploads"
        {
            try
            {
                //проверяваме дали съществува директория Uploads:

                var wwwPath = this.environment.WebRootPath;
                var path = Path.Combine(wwwPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // задаваме позволените разширения:

                var ext = Path.GetExtension(imageFile.FileName);
                var allowedExtensions = new string[] { ".jpg", ".png", ".jpeg" };
                if (!allowedExtensions.Contains(ext))
                {
                    string msg = string.Format("Only {0} extensions are allowed", string.Join(",", allowedExtensions));
                    return new Tuple<int, string>(0, msg);
                }
                string uniqueString = Guid.NewGuid().ToString();

                // създаваме уникално име на файл:

                var newFileName = uniqueString + ext;
                var fileWithPath = Path.Combine(path, newFileName);
                var stream = new FileStream(fileWithPath, FileMode.Create);
                imageFile.CopyTo(stream);
                stream.Close();
                return new Tuple<int, string>(1, newFileName);
            }
            catch (Exception ex)
            {
                return new Tuple<int, string>(0, "Error has occured");
            }
        }

        public bool DeleteImage(string imageFileName) //Взима името на даден снимков файл и изтрива съответстващия файл от директорията "Uploads"
        {
            try
            {
                var wwwPath = this.environment.WebRootPath;
                var path = Path.Combine(wwwPath, "Uploads\\", imageFileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
