﻿namespace NetCoreRunAsWindowsService.ServiceBase
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public static class ServiceBaseLifetimeHostExtensions
    {
        public static Task RunAsServiceAsync(
            this IHostBuilder hostBuilder,
            CancellationToken cancellationToken = default)
        {
            return hostBuilder.UseServiceBaseLifetime().Build().RunAsync(cancellationToken);
        }

        public static IHostBuilder UseServiceBaseLifetime(this IHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureServices(
                (hostContext, services) => services.AddSingleton<IHostLifetime, ServiceBaseLifetime>());
        }
    }
}