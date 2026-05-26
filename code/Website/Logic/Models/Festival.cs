namespace Logic.Models
{
	public class Festival
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public DateOnly Date { get; set; }
		public TimeOnly StartingTime { get; set; }
		public TimeOnly EndingTime { get; set; }
		public string? Location { get; set; } = string.Empty;
		public string City { get; set; }
		public List<Genre> Genres { get; set; } 
		public string? Description { get; set; } = string.Empty;
		public List<Ticket> Tickets { get; set; }
		public List<string> LineUp { get; set; }
		public string? TicketLink { get; set; } = string.Empty;

		public Festival(int id, string name, string imgaeUrl, DateOnly date, TimeOnly start, TimeOnly end, string location, string city, List<Genre> genres, string description, List<Ticket> tickets, List<string> lineUp, string ticketLink)
		{
			Id = id;
			Name = name;
			ImageUrl = imgaeUrl;
			Date = date;
			StartingTime = start;
			EndingTime = end;
			Location = location;
			City = city;
			Genres = genres;
			Description = description;
			Tickets = tickets;
			LineUp = lineUp;
			TicketLink = ticketLink;
		}
	}

}