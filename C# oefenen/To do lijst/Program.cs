using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace To_do_lijst
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> toDoList = new List<string>();
			bool doorgaan = true;

			while (doorgaan)
			{
				Console.WriteLine("=== To-Do lijst ===");
				Console.WriteLine("1. Taak toevoegen");
				Console.WriteLine("2. Taken bekijken");
				Console.WriteLine("3. Taak verwijderen");
				Console.WriteLine("4. Stoppen");

				Console.Write("Maak een keuze: ");
				string keuze = Console.ReadLine();
				Console.Clear();

				switch (keuze)
				{
					case "1":
						Console.WriteLine("Voeg een taak toe en druk op ENTER!");

						toDoList.Add(Console.ReadLine());
						Console.Clear();

						Console.WriteLine("Activiteit toegevoegd!");
						Thread.Sleep(3000);
						Console.Clear();
						break;

					case "2":
						if (toDoList.Count == 0)
						{
							Console.WriteLine("Er zijn nog geen taken toegevoegd!");
							Console.ReadKey();
							Console.Clear();
						}
						else
						{
							Console.WriteLine("=== Jouw taken ===");
							for (int i = 0; i < toDoList.Count; i++)
							{
								Console.WriteLine($"{i + 1}. {toDoList[i]}");
							}
							Console.ReadKey();
							Console.Clear();
						}
						break;

					case "3":
						if (toDoList.Count == 0)
						{
							Console.WriteLine("Er zijn nog geen taken toegevoegd!");
							Console.ReadKey();
							Console.Clear();
							break;
						}

						Console.WriteLine("Welke taak wil je verwijderen?");
						for (int i = 0; i < toDoList.Count; i++)
						{
							Console.WriteLine($"{i + 1}. {toDoList[i]}");
						}

						Console.WriteLine();
						Console.Write("Nummer: ");
						if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= toDoList.Count)
						{
							toDoList.RemoveAt(index - 1);
							Console.Clear();
							Console.WriteLine("Taak verwijderd!");
							Console.ReadKey();
							Console.Clear();
						}
						else
						{
							Console.WriteLine("Ongeldige keuze!");
						}

						break;
					case "4":
						doorgaan = false;
						break;
				}
			}
			Console.WriteLine("Houdoe en bedankt!");
		}
	}
}
