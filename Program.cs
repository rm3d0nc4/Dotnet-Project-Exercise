var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


// dotnet add package Microsoft.EntityFrameworkCore --version 6.0.1
// dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.1
// dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.1
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.1
// dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.1
// dotnet add package Microsoft.EntityFrameworkCore.Relational --version 6.0.1
// dotnet add package System.Configuration.ConfigurationManager --version 6.0.1
// dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0.1