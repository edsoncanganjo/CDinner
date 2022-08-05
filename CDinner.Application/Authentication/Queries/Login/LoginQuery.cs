
using CDinner.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace CDinner.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;