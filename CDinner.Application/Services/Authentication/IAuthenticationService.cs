using CDinner.Application.Common.Errors;
using OneOf;

namespace CDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    OneOf<AuthenticationResult, DuplicateEmailError> Register(string firstName, string lastName, string email, string password);
    AuthenticationResult Login(string email, string password);
}