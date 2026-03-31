using System;
using System.Collections.Generic;
using System.Linq;

public class ArtistParser
{
	public static List<string> ParseArtists(string input)
	{
		if (string.IsNullOrWhiteSpace(input))
			return new List<string>();

		// Splits op komma's, puntkomma's, nieuwe regels, tabs
		char[] separators = { ',', ';', '\n', '\r', '\t' };

		return input
			.Split(separators, StringSplitOptions.RemoveEmptyEntries)
			.Select(a => a.Trim())        // spaties weghalen
			.Where(a => a.Length > 0)     // lege regels filteren
			.ToList();
	}
}

class Program
{
	static void Main()
	{
		string rawArtists = Console.ReadLine();

		List<string> artists = ArtistParser.ParseArtists(rawArtists);

		foreach (var artist in artists)
		{
			Console.WriteLine(artist);
			// hier kun je ze in je database opslaan
		}
	}
}