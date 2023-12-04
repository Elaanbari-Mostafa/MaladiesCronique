using APIMaladiesCronique.Data;
using APIMaladiesCronique.Services.HabilitationService.Classes;
using APIMaladiesCronique.Services.HabilitationService.Interfaces;
using APIMaladiesCronique.Tools;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
        builder.WithOrigins(configuration["CorsSettings:AllowedOrigin"])
               .AllowAnyHeader()
               .AllowAnyMethod());
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataProtection();

builder.Services.AddDbContext<MaladiesCroniqueDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MaladiesCroniqueConnectionString")));
builder.Services.AddScoped<JwtTool>();
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
app.UseCors("AllowSpecificOrigin");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
