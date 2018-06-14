using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Polymorphism
{
    class Derived : Base
    {
        public new void Print()
        {
            Console.WriteLine("Print Derived");
        }

        public override void PrintVirtual()
        {
            Console.WriteLine("Print Derived Virtual");
        }

        public override void PrintNumber(double n)
        {
            Console.WriteLine(n);
        }

        public void PrintNumber(int n)
        {
            Console.WriteLine(n);
        }
    }
}
