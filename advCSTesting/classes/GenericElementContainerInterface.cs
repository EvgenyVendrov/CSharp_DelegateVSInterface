using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advCSTesting
{
    //in this class we'll derive from the base - genericElementContainer class to add an interface 
    //with which we could inject any function to the class and use it on all elements
    class GenericElementContainerInterface<T> :GenericElementContainer<T> where T:struct
    {
        //properties:
        private IElementFunc<T> _givenFunction;

        //ctors:
        public GenericElementContainerInterface(IElementFunc<T> givenFunction):base()
        {
            _givenFunction = givenFunction;
        }

        public GenericElementContainerInterface():base()
        {
       
        }
        
        //setter for the method:
        public void setMethod(IElementFunc<T> input)
        {
            _givenFunction = input;
        }

        //using the method on all elements:
        public T useGivenMethodOnAllElements()
        {
            T output;
            if (base._list.Count == 0)
            {
                throw new Exception("list is empty");
            }
            else if (_givenFunction==null)
            {
                throw new Exception("no function inserted");
            }
            else
            {
            output = _givenFunction.arithmeticAction(_list.ToArray());
            }
            return output; 
        }


    }
}
