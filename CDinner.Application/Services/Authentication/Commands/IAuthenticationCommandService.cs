using CDinner.Application.Services.Authentication.Common;
using ErrorOr;

namespace CDinner.Application.Services.Authentication.Commands;

public interface IAuthenticationCommandService
{
    ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
}