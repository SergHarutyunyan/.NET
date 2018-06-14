using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Polymorphism
{
    class DerivingDerived : Derived
    {
        public new void Print()
        {
            Console.WriteLine("Print DerivingDerived");
        }

        public override void PrintVirtual()
        {
            Console.WriteLine("Print DerivingDerived Virtual");
        }

        public void PrintBase()
        {
            base.Print();
        }

        public void PrintBaseVirtual()
        {
            base.PrintVirtual();
        }
    }
}
