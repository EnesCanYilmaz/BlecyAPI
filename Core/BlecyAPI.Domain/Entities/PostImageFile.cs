using System;
namespace BlecyAPI.Domain.Entities
{
	public class PostImageFile : File
	{
		public ICollection<Post> Posts { get; set; }
	}
}

