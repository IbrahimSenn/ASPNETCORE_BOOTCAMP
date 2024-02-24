using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//MVC çalışmadığımız için controller gibi bazı mvc özelliklerini kendimiz dahil ediyoruz. Öncelikle Controller ile view arasındaki bağlantıyı bulid edeceğiz.
builder.Services.AddControllersWithViews();//bunu yazarak controller view ilişkisini kurmuş olduk.

builder.Services.AddDbContext<BlogContext>(options =>{
var config = builder.Configuration;
var connectionString = config.GetConnectionString("sql_connection");
options.UseSqlite(connectionString);
});

builder.Services.AddScoped<IPostRepository,EfPostRepository>();

var app = builder.Build();

app.UseStaticFiles();

SeedData.TestVerileriDoldur(app); //Bunu görebilmek için önce uygulamayı çalıştırıp daha sonra veri tabanına bakmamız gerekli.


app.MapDefaultControllerRoute(); //Controller için id bağlantısı oluşturmak için bu satırı yazıyoruz. 

app.Run();
