using System.IdentityModel.Tokens.Jwt;

namespace MRecipes.Api.Services;

public static class JwtHelpers
{
    public static string GetUserIdFromToken(string token)
    {
        var token2 = token.Replace("Bearer ", "");
        var jwtHandler = new JwtSecurityTokenHandler();
        var jwtToken = jwtHandler.ReadJwtToken(token2);

        // Get the "sub" claim which typically represents the user ID
        var userId = jwtToken.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;

        return userId;
    }
}
