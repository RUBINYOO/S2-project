using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Logic
{
	public class Account
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
		public List<Festival> Favorites { get; set; }

	}
}
