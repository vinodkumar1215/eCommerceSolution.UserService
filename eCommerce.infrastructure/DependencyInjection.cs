using eCommerce.Core.RepositoryContracts;
using eCommerce.infrastructure.DbContext;
using eCommerce.infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IUsersRepository, UsersRepository>();

        services.AddTransient<DapperDbContext>();

        return services;
    }
}
