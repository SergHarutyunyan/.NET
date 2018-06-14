using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.RefReturns_and_RefLocals
{
    class RefExample<T>
    { 
        public ref T GetIndex(ref T[] a, int index)
        {
            if (a.Length > 0)
                return ref a[index];
            throw new IndexOutOfRangeException();
        }
    }
}
