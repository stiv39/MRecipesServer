using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MRecipes.Api.Identity;
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

var jwtSettings = new JwtSettings();
builder.Configuration.Bind(JwtSettings.SectionName, jwtSettings);

builder.Services.AddSingleton(Options.Create(jwtSettings));

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = builder.Configuration.GetSection("JwtSettings:Issuer").Value!,
        ValidAudience = builder.Configuration.GetSection("JwtSettings:Audience").Value!,
        ValidateIssuer = true,
        ValidateAudience = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JwtSettings:Secret").Value!)),
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(IdentityData.RoleUserPolicyName, p =>
    {
        p.RequireClaim(IdentityData.RoleUserClaimName, "Admin");
    });
});

// Add services to the container.
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IArticleCommentService, ArticleCommentService>();
builder.Services.AddScoped<IArticleMapper, ArticleMapper>();


builder.Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

builder.Services.AddControllers();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
