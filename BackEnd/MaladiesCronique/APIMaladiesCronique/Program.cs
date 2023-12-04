global using APIMaladiesCronique.Tools;

using APIMaladiesCronique.Data;
using APIMaladiesCronique.Services.HabilitationService.Classes;
using APIMaladiesCronique.Services.HabilitationService.Interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataProtection();
builder.Services.AddDbContext<MaladiesCroniqueDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MaladiesCroniqueConnectionString")));
//interface ingection
builder.Services.AddScoped<IUtilisateurService, UtilisateurService>();
//
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
