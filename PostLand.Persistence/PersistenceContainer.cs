using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PostLand.Application.Contracts;
using PostLand.Persistence.Repositories;

namespace PostLand.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SqlConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped(typeof(IPostRepository),typeof(PostRepository));

            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));


            return services;
        }
    }
}
