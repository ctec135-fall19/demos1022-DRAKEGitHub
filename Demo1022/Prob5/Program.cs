using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    class Program
    {
        static void Main(string[] args)
        {
            // create some objects to use for testing
            MyClass[] mcArray = new MyClass[6];
            MyClass mc1 = new MyClass("A", 3);
            MyClass mc2 = new MyClass("B", 9);
            MyClass mc3 = new MyClass("B", 3);
            MyClass mc4 = new MyClass("C", 4);
            MyClass mc5 = new MyClass("A", 7);
            MyClass mc6 = new MyClass("B", 6);

            // test logic - expect positive, i.e. B follows A
            Console.WriteLine(mc1.CompareTo(mc2));
            Console.WriteLine();

            // put test objects in array
            MyClass[] mcArray = new MyClass[6];
            mcArray[0] = mc1;
            mcArray[1] = mc2;
            mcArray[2] = mc3;
            mcArray[3] = mc4;
            mcArray[4] = mc5;
            mcArray[5] = mc6;

            //sort array
            Array.Sort(mcArray);

            //print sorted array
            foreach (MyClass element in mcArray)
                Console.WriteLine(element);
        }
    }
}
