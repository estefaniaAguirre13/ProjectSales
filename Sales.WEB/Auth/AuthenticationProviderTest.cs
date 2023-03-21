using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimous = new ClaimsIdentity();
            var tefaUser = new ClaimsIdentity(new List<Claim>
            {
                new Claim("FirstName", "Estefa"),
                new Claim("LastName", "Aguirre"),
                new Claim(ClaimTypes.Name, "tefa@yopmail.com"),
                new Claim(ClaimTypes.Role, "Admin")
            },
            authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(tefaUser)));
        }
    }
}

