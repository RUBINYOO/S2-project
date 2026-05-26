namespace Logic.Models
{
	public class Genre
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Festival> Festivals { get; set; }

		public Genre(int id, string name)
		{
			Id = id;
			Name = name;
			Festivals = new List<Festival>();
		}

		public Genre(int id, string name, List<Festival> festivals)
		{
			Id = id;
			Name = name;
			Festivals = festivals;
		}
	}
}
