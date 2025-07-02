using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Dependency_Injection.Constructor_Injection
{

    interface IToolBuilder
    {

        public void SetHammer(Hammer hammer);

        public void SetDrillMachine(DrillMachine drillMachine);

    }


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


    internal class Builder : IToolBuilder
    {

        Hammer _hammer;
        DrillMachine _drillMachine;
        
        public Builder()
        {
        }
        
        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }
        public void SetDrillMachine(DrillMachine drillMachine)
        {
            _drillMachine = drillMachine;   
        }

        public void BuildHouse()
        {
            _hammer.Use();
            _drillMachine.Use();
            Console.WriteLine("Building House..");
        }
    }
}
