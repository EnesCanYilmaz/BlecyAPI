using System;
using BlecyAPI.Application.Repositories.Post;
using BlecyAPI.Persistence.Contexts;

namespace BlecyAPI.Persistence.Repositories.Post
{
	public class PostReadRepository : ReadRepository<Domain.Entities.Post>, IPostReadRepository
	{
		public PostReadRepository(BlecyAPIDbContext context) : base(context)
		{
		}
	}
}

