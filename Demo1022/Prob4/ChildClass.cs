using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class ChildClass : ParentClass
    {
        public override void SomeMethod()
        {
            Console.WriteLine("SomeMethod() from Child Class");
        }

        // Demonstrate a child method calling a parent method
        // parent has a basic behavior and the child will add on to that
        public override void Method2()
        {
            // calls the base which is ParentClass 
            base.Method2();
            Console.WriteLine("Child.Method2");
        }
    }
}
