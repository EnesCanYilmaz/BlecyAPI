using System;
using BlecyAPI.Application.Repositories.Post;
using BlecyAPI.Persistence.Contexts;

namespace BlecyAPI.Persistence.Repositories.Post
{
	public class PostWriteRepository : WriteRepository<Domain.Entities.Post>, IPostWriteRepository
	{
		public PostWriteRepository(BlecyAPIDbContext context) : base(context)
		{

		}
	}
}

