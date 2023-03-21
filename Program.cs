using Katalog.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Katalog.Repositories.Abstract;
using Katalog.Repositories.Implementation;
using Katalog.Repositories.Implement;
using Katalog.Repositories.Implementation;

var builder = WebApplication.CreateBuilder(args); //използва се за конфигуриране и изграждане на уеб приложението.


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserAuthenticationService, UserAuthenticationService>(); //Позволява на уеб приложението да удостоверява и упълномощава потребителите.
builder.Services.AddScoped<IGenreService, GenreService>(); //Позволява на уеб приложението да извършва свързани с жанра операции върху филми.
builder.Services.AddScoped<IFileServices, FileServices>(); //Позволява на уеб приложението да извършва операции, свързани с файлове - качване на файлове.
builder.Services.AddScoped<IMovieService, MovieService>(); //Позволява на уеб приложението да извършва операции, свързани с филми - добавяне, ъпдейтване и изтриване на филми.


builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conn"))); //SQL connection string - "conn"

// For Identity  
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<DatabaseContext>()
    .AddDefaultTokenProviders();



var app = builder.Build();

// HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
