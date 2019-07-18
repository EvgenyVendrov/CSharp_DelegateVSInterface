using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advCSTesting
{
    class EnteryPoint
    {
        static void Main(string[] args)
        {

            //using an interface
            bool ERR = false;
            int funcOutput = 0;
            GenericElementContainerInterface<int> firstTest = new GenericElementContainerInterface<int>();
            firstTest.setMethod(new firstMethodInjection<int>());
            try
            {
                funcOutput=firstTest.useGivenMethodOnAllElements();
            }
            catch (Exception e)
            {
                Console.WriteLine("first try -> "+e.Message);
            }
            for(var i = 0; i < 10; i++)
            {
                firstTest.set(i*7);
            }
            try
            {
                funcOutput=firstTest.useGivenMethodOnAllElements();
            }
            catch (Exception e)
            {
                ERR = true;
                Console.WriteLine("first try -> " + e.Message);
            }
            if (!ERR)
            {
                Console.WriteLine("succeed, biggest num is "+funcOutput);
            }

            //using a delegate
            GenericElementContainerDelegate<int> secondTest = new GenericElementContainerDelegate<int>();
            //creating the same function as we injected in the first half
            Func<int[], int> toSet = delegate (int [] arr)
            {
              foreach(var index in arr)
                    Console.WriteLine(index);
                var output = arr.Max();
                return output;
            };
            secondTest.setDelegate(toSet);
            Console.WriteLine("second test:");
            try
            {
                secondTest.useGivenMethodOnAllElements();
            }
            catch(Exception e)
            {
                Console.WriteLine("first try->"+e.Message);
            }
            for (var i = 0; i < 10; i++)
            {
                secondTest.set(i * 7);
            }
            try
            {
                funcOutput = secondTest.useGivenMethodOnAllElements();
            }
            catch (Exception e)
            {
                ERR = true;
                Console.WriteLine("first try -> " + e.Message);
            }
            if (!ERR)
            {
                Console.WriteLine("succeed, biggest num is " + funcOutput);
            }

            Console.ReadKey(); 

        }
    }
}
