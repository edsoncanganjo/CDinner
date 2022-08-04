using CDinner.Domain.Entities;

namespace CDinner.Application.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}