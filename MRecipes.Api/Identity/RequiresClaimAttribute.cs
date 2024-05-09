using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace MRecipes.Api.Identity;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class RequiresClaimAttribute : Attribute, IAuthorizationFilter
{
    private readonly string _claimType;
    private readonly string _claimValue;

    public RequiresClaimAttribute(string claimType, string claimValue)
    {
        _claimType = claimType;
        _claimValue = claimValue;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var hasClaim = context.HttpContext.User.HasClaim(ClaimTypes.Role, _claimValue);
        if (hasClaim == false)
        {
            context.Result = new ForbidResult();
        }
    }
}
