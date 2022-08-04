using Microsoft.AspNetCore.Mvc.Infrastructure;
using CDinner.Api.Common.Errors;
using CDinner.Application;
using CDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // DependencyInjection
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory, CDinnerProblemDetailsFactory>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
