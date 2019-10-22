using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            //object that is independent from the class
            string s = "string from main";

            // passing s into the MyClass class to create an object
            MyClass mc = new MyClass(s);

            mc.printState();
            
        }
    }
}
