using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("ford", "Mustang", 1999, "blue");
            Car car2= new Car("ford", "Mustang", 1999, "blue");

			car1.Drive();
            car2.Drive();


            Console.ReadKey();
        }
    }
    
}
