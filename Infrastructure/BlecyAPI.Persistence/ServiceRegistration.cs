using System;
using BlecyAPI.Application.Repositories.Post;
using BlecyAPI.Domain.Identity;
using BlecyAPI.Persistence.Contexts;
using BlecyAPI.Persistence.Repositories.Post;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlecyAPI.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			services.AddDbContext<BlecyAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<BlecyAPIDbContext>();

            services.AddScoped<IPostReadRepository, PostReadRepository>();
            services.AddScoped<IPostWriteRepository, PostWriteRepository>();
        }
	}
}
