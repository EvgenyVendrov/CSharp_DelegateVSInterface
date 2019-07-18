using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advCSTesting
{
    //implementation of the "IElementFunc" interface 
    //this time I'll create a function which will print all elements and return the max sized one
    //will work only on "values" i.e primitive types
    class firstMethodInjection<T> : IElementFunc<T> where T:struct
    {
        public T arithmeticAction(params T[] elemnt) 
        {
            T output;
            output = elemnt.Max();
            foreach(var index in elemnt)
            {
                Console.WriteLine(index);
            }
            return output;
        }
    }
}
