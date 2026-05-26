using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Logic.Models
{
	public enum Role
	{
		User,
		Organizer,
	}
	public class Account
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public Role RoleType { get; set; }
		public List<Festival> Favorites { get; set; }

		public Account(int id, string userName, string email, string password, Role roleType, List<Festival> favorites)
		{
			Id = id;
			UserName = userName;
			Email = email;
			Password = password;
			RoleType = roleType;
			Favorites = favorites;
		}
	}
}
