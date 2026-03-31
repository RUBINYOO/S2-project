using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2e_rekenmashine_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doorgaan = true;

            while (doorgaan)
            {
                Console.WriteLine("===Rekenmashine===");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");

                string keuze = Console.ReadLine();
                Console.Clear();
                if (keuze != "1" && keuze != "2" && keuze != "3" && keuze != "4")
                {
                    Console.WriteLine("Deze keuze is geen optie");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("vul het eerste getal in: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("ongeldige invoer. \n");
                    continue;
                }
				Console.WriteLine("vul het tweede getal in: ");
				if (!double.TryParse(Console.ReadLine(), out double b))
				{
					Console.WriteLine("ongeldige invoer. \n");
                    continue;
				}

                double resultaat = 0;
                bool geldigeBewerking = true;

                switch (keuze)
                {
                    case "1":
                        resultaat = a + b;
                        break;
                    case "2":
                        resultaat = a - b;
                        break;
                    case "3":
                        resultaat = a * b;
                        break;
                    case "4":
                        if (b == 0)
                        {
                            Console.WriteLine("je kunt niet delen door 0, \n");
                            geldigeBewerking = false;
                        }
                        else
                        {
                            resultaat = a / b;
                        }
                        break;
                }
                if (geldigeBewerking)
                {
                    Console.WriteLine("\n" + resultaat);
                }
                Console.WriteLine("Druk op ENTER om verder te gaan...");
                Console.ReadLine();
                Console.Clear();
			}
		}
    }
}
