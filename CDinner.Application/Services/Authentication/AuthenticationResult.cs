using CDinner.Domain.Entities;

namespace CDinner.Application.Services.Authentication;
public record AuthenticationResult(
    User User,
    string Token
);
