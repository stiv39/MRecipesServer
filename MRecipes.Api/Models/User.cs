using System.ComponentModel.DataAnnotations;

namespace MRecipes.Api.Models;

public class User
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PasswordSalt { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public UserRole Role { get; set; }

    [Required]
    public DateOnly BirthDate { get; set; }
}
