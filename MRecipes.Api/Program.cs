using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Cors is great

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyCorsPolicy", policy => { policy.WithOrigins().AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MRecipesDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyCorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
