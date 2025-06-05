namespace MRecipes.Api.Contracts;

public class TagDto
{
    public Guid TagId { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool HasImage { get; set; }
}
