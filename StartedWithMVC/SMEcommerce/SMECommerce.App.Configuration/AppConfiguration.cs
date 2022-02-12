using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SMEcommerce.Databases.DbContexts;
using SMEcommerce.Repositories;
using SMEcommerce.Repositories.Abstractions;
using SMECommerce.Repositories;
using SMECommerce.Services;
using SMECommerce.Services.Abstractions;

namespace SMECommerce.App.Configuration
{
    public class AppConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SMEcommerceDbcontext>(c => c.UseSqlServer(@"Server=DELL\SQLEXPRESS; Database = SMEcommerceDB; Integrated Security=True"));
            services.AddTransient<ICategoryRepository, CategoryRepositories>();
            services.AddTransient<IPremiumCategoryRepository, PremiumCategoryRepository>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
