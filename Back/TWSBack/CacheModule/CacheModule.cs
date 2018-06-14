using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CacheModule
    {
        public static IServiceCollection AddCacheModule(this IServiceCollection services,
            IConfiguration configurationRoot)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            if (configurationRoot == null)
            {
                throw new ArgumentNullException(nameof(configurationRoot));
            }

            services.AddDistributedRedisCache(option =>
            {
                option.Configuration = configurationRoot.GetSection("Cache:Server")?.Value ?? "localhost";
                option.InstanceName = configurationRoot.GetSection("Cache:InstanceName")?.Value ?? "master";
            });
            return services;
        }
    }
}
