using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.LocalFunctionsWithExceptions
{
    class WithoutLocalFuncExample
    {
        public static IEnumerable<int> OddSequence(int start, int end)
        {
            if (start < 0 || start > 99)
                throw new ArgumentOutOfRangeException("start must be between 0 and 99.");
            if (end > 100)
                throw new ArgumentOutOfRangeException("end must be less than or equal to 100.");
            if (start >= end)
                throw new ArgumentException("start must be less than end.");

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 1)
                    yield return i;
            }
        }    
    }

    class WithLocalFunc
    {
        public static IEnumerable<int> OddSequence(int start, int end)
        {
            if (start < 0 || start > 99)
                throw new ArgumentOutOfRangeException("start must be between 0 and 99.");
            if (end > 100)
                throw new ArgumentOutOfRangeException("end must be less than or equal to 100.");
            if (start >= end)
                throw new ArgumentException("start must be less than end.");

            return GetOddSequenceEnumerator();

            IEnumerable<int> GetOddSequenceEnumerator()
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 1)
                        yield return i;
                }
            }
        }
    }
}
