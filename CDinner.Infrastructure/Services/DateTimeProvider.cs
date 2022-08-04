using CDinner.Application.Common.Interfaces.Services;

namespace CDinner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}