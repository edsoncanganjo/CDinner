using CDinner.Api.Common.Errors;
using CDinner.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CDinner.Api;
public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, CDinnerProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}
