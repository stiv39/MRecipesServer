using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Contracts;
using MRecipes.Api.Models;
using MRecipes.Api.Persistence;
using MRecipes.Api.Services;

namespace MRecipes.Api.Controllers;

[AllowAnonymous]
[Route("/[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly MRecipesDbContext _dbContext;
    private readonly IJwtTokenGenerator _tokenGenerator;
    private readonly IPasswordService _passwordService;

    public AuthenticationController(MRecipesDbContext dbContext, IJwtTokenGenerator tokenGenerator, IPasswordService passwordService)
    {
        _dbContext = dbContext;
        _tokenGenerator = tokenGenerator;
        _passwordService = passwordService;
    }

    [HttpPost("/register")]
    public async Task<IActionResult> Register([FromBody] Contracts.RegisterDto request, CancellationToken cancellationToken)
    {
        var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email || u.Name == request.Name);

        if (existingUser != null)
        {
            return BadRequest();
        }
        var id = Guid.NewGuid();

        var hash = _passwordService.EncryptPassword(request.Password, out string salt);

        var user = new User
        {
            Id = id,
            Email = request.Email,
            Name = request.Name,
            BirthDate = request.BirthDate,
            PasswordHash = hash,
            PasswordSalt = salt,
            Role = UserRole.User 
        };

        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return Ok();
    }

    [HttpPost("/login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == dto.Email.ToLower(), cancellationToken);

        if(user == null)
        {
            return NotFound();
        }

        if (user.Role == UserRole.User) { return Unauthorized(); }

        if(!_passwordService.VerifyPassword(dto.Password, user.PasswordHash, user.PasswordSalt))
        {
            return BadRequest("Wrong credentials");
        }

        var token = _tokenGenerator.GenerateToken(user);

        var response = new LoginResponse(user.Role.ToString(), token);

        return Ok(response);
    }
}
