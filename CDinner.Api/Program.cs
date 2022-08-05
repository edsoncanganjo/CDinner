using CDinner.Application;
using CDinner.Infrastructure;
using CDinner.Api;

var builder = WebApplication.CreateBuilder(args);
{
    // DependencyInjection
    builder.Services
        .AddPresentation()
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
