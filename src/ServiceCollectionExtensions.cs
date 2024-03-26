using Microsoft.Extensions.DependencyInjection;

namespace Wasm.Modal;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWasmModal(this IServiceCollection services)
    {
        services.AddScoped<IModalManager, ModalManager>();
        return services;
    }
}