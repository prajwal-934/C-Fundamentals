using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Generics
{
    internal class GenericClass<T>
    {
        public  T[] createArray<T>(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }
    }
}
