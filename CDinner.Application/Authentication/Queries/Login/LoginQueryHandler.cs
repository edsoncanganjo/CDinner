using CDinner.Application.Common.Interfaces.Authentication;
using CDinner.Application.Common.Interfaces.Persistence;
using CDinner.Domain.Entities;
using CDinner.Domain.Common.Errors;
using ErrorOr;
using MediatR;
using CDinner.Application.Authentication.Common;

namespace CDinner.Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{

    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        // 1. Validate the user exists
        if(_userRepository.GetUserByEmail(query.Email) is not User user){
            return Errors.Authentication.InvalidCredentials;
        }
        // 2. Validate the password is correct
        if(user.Password != query.Password){
            return Errors.Authentication.InvalidCredentials;
        }
        // 3. Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return await Task.FromResult(new AuthenticationResult(user, token));
    }
}