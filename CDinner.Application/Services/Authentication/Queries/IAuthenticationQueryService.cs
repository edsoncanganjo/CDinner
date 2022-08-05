using ErrorOr;
using CDinner.Application.Services.Authentication.Common;

namespace CDinner.Application.Services.Authentication.Queries;

public interface IAuthenticationQueryService
{
    ErrorOr<AuthenticationResult> Login(string email, string password);
}