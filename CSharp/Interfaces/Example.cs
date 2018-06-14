using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Interfaces
{
    class Example : IExample
    {
        private int _name;
        private int _age;

        public int name { get => _name; set => _name = value; }         // Overriding properties implementations.
        public int age => _age;

        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void fly()                                               // Implicit Implementation
        {
            Console.WriteLine("Implicit Fly");
        }

        void IExample.fly()                                               // Explicit Implementation
        {
            Console.WriteLine("Explicit Fly");
        }

        public void CallExplicitFly()
        {
            (this as IExample).fly();
        }
    }
}
