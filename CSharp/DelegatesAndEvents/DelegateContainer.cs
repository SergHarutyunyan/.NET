using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DelegatesAndEvents
{
    class DelegateContainer
    {
        public delegate void Print(string message);

        public delegate void Sum(int a, int b);
    }
}
