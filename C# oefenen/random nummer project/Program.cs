using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_nummer_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int geheimGetal = random.Next(1,21);
            int poging = 0;

            Console.WriteLine("Raad het getal tussen 1 en 20");

            while (true)
            {
                Console.Write("Jouw gok: ");
                string invulGetal = Console.ReadLine();
                poging++;

                if (int.TryParse(invulGetal, out int gok))
                {
                    if (gok == geheimGetal)
                    {
                        Console.WriteLine("wat goed.");
                    }
                    else if (gok < geheimGetal)
                    {
                        Console.WriteLine("het getal moet groter");
                    }
                    else
                    {
                        Console.WriteLine("het getal moet kleiner");
                    }
                }
                else
                {
                    Console.WriteLine("voer een geldig getal in");
                }

            }
        }
    }
}
