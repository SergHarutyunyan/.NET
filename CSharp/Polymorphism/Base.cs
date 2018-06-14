using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Polymorphism
{
    class Base
    {
        public int A;
        public int B { get; set; }

        public void Print()
        {
            Console.WriteLine("Print Base");
        }

        public virtual void PrintVirtual()
        {
            Console.WriteLine("Print Base Virtual");
        }

        public virtual void PrintNumber(double n)
        {
            Console.WriteLine(n);
        }
    }
}
