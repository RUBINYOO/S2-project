using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_rekenmashine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kies je eerste getal:");
            double a = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Kies +,-,* of /");
			string c = Console.ReadLine();

			Console.WriteLine("Kies je tweede getal");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultaat = 0;

            if (c == "+")
            {
                resultaat = a + b;
            }
            else if (c == "-")
            {
                resultaat = a - b;
            }
            else if (c == "*")
            {
                resultaat = a * b;
            }
            else if (c == "/")
            { 
                resultaat = a / b;
                if (b == 0)
                    Console.WriteLine("Je kunt niet delen door 0.");
            }
			else 
            { 
                Console.WriteLine("Onbekende bewerking.");
                return; 
            }

			Console.WriteLine(resultaat);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
