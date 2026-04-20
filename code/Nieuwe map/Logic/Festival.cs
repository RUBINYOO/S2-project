namespace Logic
{
	public class Festival
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateOnly Date { get; set; }
		public TimeOnly StartingTime { get; set; }
		public TimeOnly EndingTime { get; set; }
		public string? Location { get; set; } = string.Empty;
		public string City { get; set; }
		public string? Genre { get; set; } = string.Empty;
		public string? Description { get; set; } = string.Empty;
		public List<Ticket> Tickets { get; set; }
		public List<string> LineUp { get; set; }
		public string? TicketLink { get; set; } = string.Empty;

		public Festival(int id, string name, DateOnly date, TimeOnly start, TimeOnly end, string location, string city, string genre, string description, List<Ticket> tickets, List<string> lineUp, string ticketLink)
		{
			Id = id;
			Name = name;
			Date = date;
			StartingTime = start;
			EndingTime = end;
			Location = location;
			City = city;
			Genre = genre;
			Description = description;
			Tickets = tickets;
			LineUp = lineUp;
			TicketLink = ticketLink;
		}
	}

}