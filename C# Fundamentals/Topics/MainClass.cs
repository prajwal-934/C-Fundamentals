using C__Fundamentals.Basic.Functions;
using C__Fundamentals.Topics.OOPM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Basic
{
    internal class MainClass
    {

        static void Main()
        {

         

            Console.WriteLine();

            Vehicle c = new Car("Tata", "Nexon", 2020, 200, "Gas", 7);
            c.ShowDetails();
            c.Run();
            Console.WriteLine();

            Vehicle ev = new ElectricVehicle("Tata", "Nexon", 2020, 250, "Gas", 7,"250Kwh");
            ev.ShowDetails();
            ev.Run();



        }

    }
}
