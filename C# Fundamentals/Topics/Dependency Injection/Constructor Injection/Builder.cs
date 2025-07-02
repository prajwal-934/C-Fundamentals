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
        Hammer _hameer;
        DrillMachine _drillMachine;
        
        public Builder(Hammer hammer , DrillMachine drillMachine)
        {
            _hameer = hammer;
            _drillMachine = drillMachine;
        }

        public void BuildHouse()
        {
            _hameer.Use();
            _drillMachine.Use();
            Console.WriteLine("Building House..");
        }
    }
}
