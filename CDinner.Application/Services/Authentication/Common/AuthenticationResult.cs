using CDinner.Domain.Entities;

namespace CDinner.Application.Services.Authentication.Common;
public record AuthenticationResult(
    User User,
    string Token
);