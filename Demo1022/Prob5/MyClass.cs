using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    class MyClass : IComparable
    {
        // fields
        private string mcStr;
        private int mcInt;

        public string McStr
        {
            get { return mcStr; }
            set { mcStr = value; }
        }

        public int McInt
        {
            get { return mcInt; }
            set { mcInt = value; }
        }

        public int CompareTo(object obj)
        {
            // cast obj to Myclass type
            MyClass mc = obj as MyClass;

            // if case successful make comparisons
            if (mc != null)
            {
                // return value corresponding to comparison
                if (string.Compare(this.McStr, mc.McStr) < 0) return -1;
                if (String.Compare(this.McStr, mc.McStr) > 0) return 1;
                else // strings are the same - compare ints
                {
                    if (this.McInt < mc.McInt) return -1;
                    if (this.McInt > mc.McInt) return 1;
                    else return 0;
                }

            }
            else
                throw new ArgumentException("Paremeter is not a MyClass object.");
        }

        // override toString so can print object
        public override string ToString()
        {
            return $"{McStr}, {McInt}";
        }
    }
}
