using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class MyClass
    {
        // fields - variables that will hold the reference in the class
        private string str;
        private string str2;

        // constructor
        public MyClass(string inStr)
        {
            // composition defined - passed from the inside
            // MyClass owns str. str doesn't exist oustide of MyClass 
            str = "some string";

            // aggregation defined - passed from  the outside
            // object exists outside of class, and the class does not own the object
            // str2 refers to object outside of MyClass
            str2 = inStr;

        }

        // printstate to print what is in the string
        public void printState()
        {
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("str2: {0}", str2);
        }
    }
}
