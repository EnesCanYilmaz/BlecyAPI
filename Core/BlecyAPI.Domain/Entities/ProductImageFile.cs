using System;
namespace BlecyAPI.Domain.Entities
{
	public class ProductImageFile : File
	{
		public ICollection<Post> Posts { get; set; }
	}
}

