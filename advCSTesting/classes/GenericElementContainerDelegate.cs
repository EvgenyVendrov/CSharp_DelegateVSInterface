using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advCSTesting
{
    //in this class we'll derive from the base - genericElementContainer class to add an delegate 
    //with which we could inject any function to the class and use it on all elements

    class GenericElementContainerDelegate<T> : GenericElementContainer<T> where T:struct
    {
        private Func<T[],T> _delegateOfClass;
        //ctors:
        public GenericElementContainerDelegate(Func<T[], T> givenDelegate) : base()
        {
            _delegateOfClass = givenDelegate;
        }

        public GenericElementContainerDelegate() : base()
        {

        }

        //setter for the method:
        public void setDelegate(Func<T[], T> givenDelegate)
        {
            _delegateOfClass = givenDelegate;
        }

        //using the method on all elements:
        public T useGivenMethodOnAllElements()
        {
            T output;
            if (base._list.Count == 0)
            {
                throw new Exception("list is empty");
            }
            else if (_delegateOfClass == null)
            {
                throw new Exception("no function inserted");
            }
            else
            {
                output = _delegateOfClass.Invoke(base._list.ToArray());
            }
            return output;
        }
    }
}
