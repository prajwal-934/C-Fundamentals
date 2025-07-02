using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Solid
{

    //lsp- child class instance should be easily subsitute to parent without breaking any code
    // in below example Ostrich cannot inherit Bird class because Ostrich cannot fly so we can create FlyingBird class
    internal class Bird
    {
        //public void Fly() { }
    }

    class FlyingBird : Bird { 
      public void Fly() { }  
    }

    class Ostrich : Bird { }

    class Pigeon : FlyingBird { }

    
}
