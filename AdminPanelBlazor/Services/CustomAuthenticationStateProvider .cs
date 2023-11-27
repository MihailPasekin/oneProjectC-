using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace AdminPanelBlazor.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private AuthenticationState authenticationState;

        public CustomAuthenticationStateProvider(AuthenticationService service)
        {
            authenticationState = new AuthenticationState(service.CurrentUser);

            service.UserChanged += (newUser) =>
            {
                authenticationState = new AuthenticationState(newUser);

                NotifyAuthenticationStateChanged(
                    Task.FromResult(new AuthenticationState(newUser)));
            };
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync() => Task.FromResult(authenticationState);
        
        public void AuthenticateUser(string userIdentifier)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, userIdentifier),
            }, "Custom Authentication");

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(user)));
        }
    }
}
