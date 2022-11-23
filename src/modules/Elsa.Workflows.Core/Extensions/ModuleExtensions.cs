using Elsa.Features.Services;
using Elsa.Workflows.Core.Features;
using Elsa.Workflows.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Elsa.Workflows.Core;

public static class ModuleExtensions
{
    public static IModule UseWorkflows(this IModule configuration, Action<WorkflowsFeature>? configure = default)
    {
        configuration.Configure(configure);
        return configuration;
    }

    public static IServiceCollection AddStorageDriver<T>(this IServiceCollection services) where T : class, IStorageDriver
    {
        return services.AddSingleton<IStorageDriver, T>();
    }
}