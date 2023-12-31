﻿namespace Exemplo.Api.Configuration
{
    public static class RedisConfig
    {
        public static IServiceCollection AddRedisConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDistributedRedisCache(options =>
            {
                options.Configuration =
                    configuration.GetConnectionString("ConnectionRedis");
                options.InstanceName = "Exemplo";
            });

            return services;
        }
    }
}
