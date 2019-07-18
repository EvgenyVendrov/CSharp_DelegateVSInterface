using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advCSTesting
{
    //the interface itself 
    interface IElementFunc<T> where T:struct
    {
        T arithmeticAction(params T[] elemnt);

    }
}
