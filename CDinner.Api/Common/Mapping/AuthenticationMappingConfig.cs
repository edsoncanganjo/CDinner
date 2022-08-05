using CDinner.Application.Authentication.Commands.Register;
using CDinner.Application.Authentication.Common;
using CDinner.Application.Authentication.Queries.Login;
using CDinner.Contracts.Authentication;
using Mapster;

namespace CDinner.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<RegisterRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}