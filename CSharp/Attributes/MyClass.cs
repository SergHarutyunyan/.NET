using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Attributes
{
    class MyClass
    {
        [Obsolete("Don't use Old method, please use New method", true)]
        public string Old() { return "Old"; }
        public string New() { return "New"; }
    }
}
