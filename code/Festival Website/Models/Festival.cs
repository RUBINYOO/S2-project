namespace Festival_Website.Models
{
	public class Festival
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public DateOnly Date { get; set; }
		public TimeOnly StartingTime { get; set; }
		public TimeOnly EndingTime { get; set; }
		public string Location { get; set; } = string.Empty;
		public string Genre { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string TicketType { get; set; } = string.Empty;
		public double TicketPrice { get; set; }
		public string LineUp { get; set; } = string.Empty;
		public string TicketLink { get; set; } = string.Empty;
	}
}