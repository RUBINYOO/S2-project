using Logic.Interfaces;
using Logic.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DAL
{
	public class FestivalRepo : IFestivalRepo
	{
		private readonly string _connectionString;

		public FestivalRepo(IConfiguration config)
		{
			_connectionString = config.GetConnectionString("DefaultConnection");
		}

		public List<Festival> GetAllFestivalsByDate()
		{
			List<Festival> festivals = new();

			using var conn = new MySqlConnection(_connectionString);
			conn.Open();

			string query = @"SELECT * FROM Festival
							 WHERE Date >= CURDATE()
							 ORDER BY Date ASC;";

			using var cmd = new MySqlCommand(query, conn);
			using var reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				int id = reader.GetInt32("ID");

				festivals.Add(new Festival(
					id,
					reader.GetString("Name"),
					reader.GetString("ImageUrl"),
					DateOnly.FromDateTime(reader.GetDateTime("Date")),
					TimeOnly.FromTimeSpan(reader.GetTimeSpan("StartingTime")),
					TimeOnly.FromTimeSpan(reader.GetTimeSpan("EndingTime")),
					reader.GetString("Location"),
					reader.GetString("City"),
					GetGenresByFestival(id),
					reader.GetString("Description"),
					GetTicketsByFestival(id),
					reader.GetString("LineUp").Split(",").Select(x => x.Trim()).ToList(),
					reader.GetString("TicketLink")
				));
			}

			return festivals;
		}

		public Festival GetFestivalById(int id)
		{
			using var conn = new MySqlConnection(_connectionString);
			conn.Open();

			string query = @"SELECT * FROM Festival WHERE ID = @id";

			using var cmd = new MySqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@id", id);

			using var reader = cmd.ExecuteReader();

			if (!reader.Read())
				return null;

			return new Festival(
				id,
				reader.GetString("Name"),
				reader.GetString("ImageUrl"),
				DateOnly.FromDateTime(reader.GetDateTime("Date")),
				TimeOnly.FromTimeSpan(reader.GetTimeSpan("StartingTime")),
				TimeOnly.FromTimeSpan(reader.GetTimeSpan("EndingTime")),
				reader.GetString("Location"),
				reader.GetString("City"),
				GetGenresByFestival(id),
				reader.GetString("Description"),
				GetTicketsByFestival(id),
				reader.GetString("LineUp").Split(",").Select(x => x.Trim()).ToList(),
				reader.GetString("TicketLink")
			);
		}

		public Festival GetFestivalByDate(DateTime date)
		{
			using var conn = new MySqlConnection(_connectionString);
			conn.Open();
			string query = @"SELECT * FROM Festival WHERE Date = @date";
			using var cmd = new MySqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@date", date);
			using var reader = cmd.ExecuteReader();
			if (!reader.Read())
				return null;
			int id = reader.GetInt32("ID");
			return new Festival(
				id,
				reader.GetString("Name"),
				reader.GetString("ImageUrl"),
				DateOnly.FromDateTime(reader.GetDateTime("Date")),
				TimeOnly.FromTimeSpan(reader.GetTimeSpan("StartingTime")),
				TimeOnly.FromTimeSpan(reader.GetTimeSpan("EndingTime")),
				reader.GetString("Location"),
				reader.GetString("City"),
				GetGenresByFestival(id),
				reader.GetString("Description"),
				GetTicketsByFestival(id),
				reader.GetString("LineUp").Split(",").Select(x => x.Trim()).ToList(),
				reader.GetString("TicketLink")
			);
		}

		private List<Genre> GetGenresByFestival(int festivalId)
		{
			List<Genre> genres = new();

			using var conn = new MySqlConnection(_connectionString);
			conn.Open();

			string query = @"
                SELECT g.ID, g.Name 
                FROM FestivalGenre fg
                JOIN Genre g ON g.ID = fg.Genre_ID
                WHERE fg.Festival_ID = @id";

			using var cmd = new MySqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@id", festivalId);

			using var reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				genres.Add(new Genre(reader.GetInt32("ID"), reader.GetString("Name")));
			}

			return genres;
		}

		private List<Ticket> GetTicketsByFestival(int festivalId)
		{
			List<Ticket> tickets = new();

			using var conn = new MySqlConnection(_connectionString);
			conn.Open();

			string query = @"SELECT * FROM Ticket WHERE Festival_ID = @id";

			using var cmd = new MySqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@id", festivalId);

			using var reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				tickets.Add(new Ticket(
					reader.GetInt32("ID"),
					reader.GetString("Type"),
					reader.GetDecimal("Price")
				));
			}

			return tickets;
		}


	}
}
