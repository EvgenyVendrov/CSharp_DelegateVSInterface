using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advCSTesting
{
    //this is the base class including the basic functionality for the generic list "family"
    class GenericElementContainer<T>
    {
        protected readonly List<T> _list = new List<T>();

        //getter for the list using inedexer:
        public T this[int key]
        {
            get
            {
                return _list.ElementAt(key);
            }
        }

        //basic setter for the list:
        public void set(T newElem)
        {
            _list.Add(newElem);
        }
    }
}
