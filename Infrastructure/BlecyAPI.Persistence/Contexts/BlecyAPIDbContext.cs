using System;
using BlecyAPI.Domain.Entities;
using BlecyAPI.Domain.Entities.Common;
using BlecyAPI.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlecyAPI.Persistence.Contexts
{
	public class BlecyAPIDbContext : IdentityDbContext<AppUser,AppRole,string>
	{
		public BlecyAPIDbContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<Post> Posts { get; set; }
		public DbSet<Domain.Entities.File> Files { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

