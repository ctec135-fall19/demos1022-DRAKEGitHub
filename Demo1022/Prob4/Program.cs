using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array of base class type created and intiialized with
            // a member of each class in the hierarchy
            ParentClass[] myArray = new ParentClass[3];
            myArray[0] = new ParentClass();
            myArray[1] = new ChildClass();
            myArray[2] = new GrandChildClass();

            // Show that a method belonging to the base class is called from a child instance
            // create ParentMethod() in Parent and iterate through array
            // calling this method to demonstrate that all child classes
            // have access to the ParentMethod()
            foreach(ParentClass element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.ParentMethod();
            }
            Console.WriteLine();
            #endregion

            #region Demonstrate overriding a base class method by a child
            // demonstrate a child method calling the parent's method
            foreach (ParentClass element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.ParentMethod();
            }
            Console.WriteLine();
            #endregion

            #region Demonstrate a child method calling the parent's method
            // create a virtual method in parent 
            // override in child and call the parent as part of the implementation.
            foreach (ParentClass element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.Method2();
                Console.WriteLine();
            }
            #endregion

            #region Demonstrate use of "as" keyword
            // repeat calls to SomeMethod
            foreach(object element in myArray)
            {
                // casting and creating new variable using as
                ParentClass pc = element as ParentClass;
                // below is the explicit cast not using as
                //ParentClass pc = (ParentClass)element;
                Console.Write("{0}: ", pc.GetType());
                pc.SomeMethod();
            }
            Console.WriteLine();
            #endregion

            #region Demonstrate use of "is" keyboard

            Console.WriteLine("Demo use of is:");
            foreach(ParentClass element in myArray)
            {
                if (element is GrandChildClass) Console.WriteLine("GrandChild Class");
                else if (element is ChildClass) Console.WriteLine("Child Class");
                else if (element is ParentClass) Console.WriteLine("Parent Class");
            }
            Console.WriteLine();
            #endregion

            #region Switch with cases
            Console.WriteLine("Demo Switch:");
            foreach (ParentClass element in myArray)
            {
                switch(element)
                {
                    case GrandChildClass gc:
                        Console.WriteLine("GrandChild in Switch");
                        break;
                    case ChildClass cc:
                        Console.WriteLine("Child Class in Switch");
                        break;
                    case ParentClass pc:
                        Console.WriteLine("Parent Class in Switch");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
            Console.WriteLine();

            #endregion

            #region create object of "object" type but intialized of the
            // base class type then cast it to the actual type so you can call 
            object obj = new ParentClass();
            // cast ParentClass on obj to call parent method
            ((ParentClass)obj).ParentMethod();

            // cast the grandchild class onto the parent class 
            ParentClass p2 = new GrandChildClass();
            ((GrandChildClass)p2).SpecializedMethod();
            Console.WriteLine();
            #endregion


        }
    }
}
