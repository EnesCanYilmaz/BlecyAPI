using System;
using BlecyAPI.Domain.Entities.Common;
using BlecyAPI.Domain.Identity;

namespace BlecyAPI.Domain.Entities
{
	public class Post : BaseEntity
	{
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<File> Files { get; set; }
	}
}

