using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class ParentClass
    {
        // show that a method belonging to the base class is called from a 
        // child instance
        public void ParentMethod()
        {
            Console.WriteLine("This print is from ParentMethod()");
        }

        // Demonstrate overriding a base class method by a child
        public virtual void SomeMethod()
        {
            Console.WriteLine("SomeMethod() from Parent Class");
        }

        // Demonstrate a child method calling a parent method
        public virtual void Method2()
        {
            Console.WriteLine("Parent.Method2");
        }


    }
}
