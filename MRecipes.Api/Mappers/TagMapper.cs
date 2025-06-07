using MRecipes.Api.Contracts;
using MRecipes.Api.Models;

namespace MRecipes.Api.Mappers;

public interface ITagMapper
{
    TagDto ToDto(Tag tag);
}

public class TagMapper : ITagMapper
{
    public TagDto ToDto(Tag tag)
        => new TagDto { TagId = tag.Id, Name = tag.Name, HasImage = HasImage(tag.Id) };

    private static bool HasImage(Guid id)
    {
        return id.ToString() switch
        {
            "8ee5d1b8-08e5-43e5-bdc9-28dc607e5825" or "a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c" or "d1e13f16-9e32-4d3e-8302-28516d982aef" or "c1d698f0-1f87-4c30-9a31-c26e75d99c4f" or "b1eac43b-9a2a-4e37-94d2-0a59a493c7d3" => true,
            _ => false,
        };
    }
}
