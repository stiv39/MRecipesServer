using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MRecipes.Api.Mappers;
using MRecipes.Api.Persistence;
using MRecipes.Api.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Cors is great

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyCorsPolicy", policy => { policy.WithOrigins().AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });
});

// Add services to the container.
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IArticleCommentService, ArticleCommentService>();
builder.Services.AddScoped<IArticleMapper, ArticleMapper>();


var jwtSettings = new JwtSettings();
builder.Configuration.Bind(JwtSettings.SectionName, jwtSettings);

builder.Services.AddSingleton(Options.Create(jwtSettings));

builder.Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

builder.Services.AddControllers();

builder.Services.AddAuthentication().AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = false,
        ValidateAudience = false,
        ValidateIssuer = false,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                builder.Configuration.GetSection("JwtSettings:Secret").Value!))
    };
}); ;

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
