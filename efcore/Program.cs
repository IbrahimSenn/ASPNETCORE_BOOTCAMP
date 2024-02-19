using efcore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
 //Sqlite işlemleri burada program build edilmeden önce yazılır.
builder.Services.AddDbContext<DataContext>(options =>{
    var config = builder.Configuration ;
    var connectionString = config.GetConnectionString("database");
    
    options.UseSqlite(connectionString);  
});
//Migration işlemi oluşturduğumuz datacontext içindeki verileri, veri tabanı kodu şeklinde oluşturup bir dosya içinde teslim eder.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
