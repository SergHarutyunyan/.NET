using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Interfaces
{
    interface IExample
    {       
        int name { get; set; }
        int age { get; }
        void fly();

        string Address
        {
            get;
            set;
        }
    }
}
