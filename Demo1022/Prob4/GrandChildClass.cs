using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class GrandChildClass : ChildClass
    {
        public override void SomeMethod()
        {
            Console.WriteLine("SomeMethod() from Grand Child");
        }

        public override void Method2()
        {
            // calls the parent which is childclass for grandchild class
            base.Method2();
            Console.WriteLine("GrandChild.Method2");
        }

        public void SpecializedMethod()
        {
            Console.WriteLine("Specialized Method from the GrandChild Class");
        }
    }
}
