using System.Text.Json.Serialization;

namespace MRecipes.Api.Contracts;

public class AddArticleDto
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("steps")]
    public List<string> Steps { get; set; } = [];

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; } = [];

    [JsonPropertyName("ingredients")]
    public string Ingredients { get; set; } = string.Empty;
}
