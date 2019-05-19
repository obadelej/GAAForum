using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GAAForum.Data.Models;

namespace GAAForum.Data.Interfaces
{
	public interface IForum
	{
		Forum GetById(int Id);
		IEnumerable<Forum> GetAll();
		IEnumerable<ApplicationUser> GetAllActiveUsers();

		Task Create(Forum forum);
		Task Delete(int forumId);
		Task UpdateForumTitle(int forumId, string newTitle);
		Task UpdateForumDescription(int forumId, string newDescription);

	}
}
