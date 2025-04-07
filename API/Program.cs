using API.Data;
using API.Extentions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddCors();
});
builder.Services.AddCors();
builder.Services.AddRepositories();
builder.Services.AddServices();

var app = builder.Build();

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));

app.MapControllers();

app.Run();
