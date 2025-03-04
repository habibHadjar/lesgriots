using Lesgriots.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lesgriots.Infrastructure
{
    public static class MongoDbServiceExtensions
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["MongoDb:ConnectionString"];
            var databaseName = configuration["MongoDb:DatabaseName"];

            services.AddSingleton<MongoDbContext>(sp =>
                new MongoDbContext(connectionString, databaseName));

            return services;
        }
    }
}
