using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopLife.Identity.Domain;

namespace ShopLife.Identity.Module
{
    public static class ServiceCollectionExtensionMethods
    {
        public static void AddIdentity(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddTransient<IIdentityContext, IdentityContext>();

            serviceCollection.AddDbContext<IdentityContext>(cfg => cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}