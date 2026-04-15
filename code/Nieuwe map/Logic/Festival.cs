namespace Logic
{
	public class Festival
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public DateOnly Date { get; set; }
		public TimeOnly StartingTime { get; set; }
		public TimeOnly EndingTime { get; set; }
		public string? Location { get; set; } = string.Empty;
		public string? Genre { get; set; } = string.Empty;
		public string? Description { get; set; } = string.Empty;
		public string? TicketType { get; set; } = string.Empty;
		public double TicketPrice { get; set; }
		public string? LineUp { get; set; } = string.Empty;
		public string? TicketLink { get; set; } = string.Empty;

		public Festival(int id, string name, DateOnly date, TimeOnly start, TimeOnly end, string location, string genre, string description, string ticketType, double ticketPrice, string lineUp, string ticketLink)
		{
			Id = id;
			Name = name;
			Date = date;
			StartingTime = start;
			EndingTime = end;
			Location = location;
			Genre = genre;
			Description = description;
			TicketType = ticketType;
			TicketPrice = ticketPrice;
			LineUp = lineUp;
			TicketLink = ticketLink;
		}
	}
}