using System;
using System.ComponentModel.DataAnnotations;

namespace GAAForum.Data.Models
{
	public class PostReply
	{
		public int Id { get; set; }
		public string Content { get; set; }

		[DataType(DataType.Date)]
		public DateTime Created { get; set; }

		public virtual ApplicationUser User { get; set; }
		public virtual Post Post { get; set; }
	}
}
