using System;
namespace BlecyAPI.Domain.Entities.Common
{
	public class BaseEntity
	{
		public Guid Id { get; set; }
		public DateTime CreatedDate { get; set; }
        virtual public DateTime UpdatedDate { get; set; }
	}
}