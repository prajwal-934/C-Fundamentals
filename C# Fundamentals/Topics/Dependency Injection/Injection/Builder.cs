using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Dependency_Injection.Constructor_Injection
{
    class Hammer
    {

        public void Use()
        {
            Console.WriteLine("Hammering..");
        }
    }

    class DrillMachine
    {
        public void Use()
        {
            Console.WriteLine("Drilling..");
        }
    }


    internal class Builder
    {
        public Hammer Hammer {get; set;}
        public DrillMachine DrillMachine { get; set; }
        
        public Builder()
        {
        }

        public void BuildHouse()
        {
            Hammer.Use();
            DrillMachine.Use();
            Console.WriteLine("Building House..");
        }
    }
}
