using ErrorOr;
using CDinner.Application.Common.Interfaces.Authentication;
using CDinner.Application.Common.Interfaces.Persistence;
using CDinner.Application.Services.Authentication.Common;
using CDinner.Domain.Common.Errors;
using CDinner.Domain.Entities;

namespace CDinner.Application.Services.Authentication.Queries;

public class AuthenticationQueryService : IAuthenticationQueryService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationQueryService(
        IJwtTokenGenerator jwtTokenGenerator,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public ErrorOr<AuthenticationResult> Login(string email, string password)
    {
        // 1. Validate the user exists
        if(_userRepository.GetUserByEmail(email) is not User user){
            return Errors.Authentication.InvalidCredentials;
        }
        // 2. Validate the password is correct
        if(user.Password != password){
            return Errors.Authentication.InvalidCredentials;
        }
        // 3. Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}
