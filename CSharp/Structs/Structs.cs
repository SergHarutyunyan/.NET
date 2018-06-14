using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Structs
{
    // A struct can implement interfaces.
    public struct Struct1 : IEqualityComparer<Struct1>
    {
        public const int a = 7;
        public static int b = 8;
        // int c = 5;       Within a struct declaration, fields cannot be initialized unless they are declared as const or static.
        public int d;
        public int e;

        // A struct cannot declare a default constructor (a constructor without parameters) or a finalizer.
        public Struct1(int first, int second)
        {
            d = first;
            e = second;
        }

        // Structs are copied on assignment. When a struct is assigned to a new variable, 
        // all the data is copied, and any modification to the new copy does not change the data for the original copy. 
        // This is important to remember when working with collections of value types such as Dictionary<string, myStruct>.

        public bool Equals(Struct1 x, Struct1 y)
        {
            return (x.d == y.d && x.e == y.e);
        }

        public int GetHashCode(Struct1 obj)
        {
            return obj.GetHashCode();
        }

      
    }
}
