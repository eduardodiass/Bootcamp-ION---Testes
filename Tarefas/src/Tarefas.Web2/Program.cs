using Microsoft.EntityFrameworkCore;
using Tarefas.Web2.Database ;
var builder = WebApplication.CreateBuilder(args);

// Conectar Base de dados utilizando a configurações que estão no appsettings.json
string conexaoMysql = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextPool<ApplicationDBContext>(options=> options.UseMySql(conexaoMysql,ServerVersion.AutoDetect(conexaoMysql)));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
