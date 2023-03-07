using System;
using BlecyAPI.Domain.Entities.Common;

namespace BlecyAPI.Domain.Entities
{
	public class Post : BaseEntity
	{
		public string Title { get; set; }
		public string Content { get; set; }

		public ICollection<PostImageFile> PostImageFiles { get; set; } 
	}
}

