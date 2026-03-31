using System.Security.Principal;

namespace Festival_Website.Models
{
	public class Account
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string PasswordHash { get; set; }
		public string Role { get; set; }
		public List<Festival> Favorites { get; set; }
	}
}
