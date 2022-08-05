using CDinner.Domain.Entities;

namespace CDinner.Application.Authentication.Common;
public record AuthenticationResult(
    User User,
    string Token
);
