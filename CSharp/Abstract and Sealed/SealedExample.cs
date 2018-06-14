using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Abstract_and_Sealed
{
    // A sealed class cannot be used as a base class.
    sealed class SealedExample
    {

    }

    class SealedBase
    {
        public virtual void DoWork()
        {

        }
    }

    class SealedMethodExample : SealedBase
    {
        public sealed override void DoWork()
        {
            /*
             *  A method, indexer, property, or event, on a derived class that is overriding a virtual member 
                of the base class can declare that member as sealed. 
                This negates the virtual aspect of the member for any further derived class.
             */
        }
    }

    class DerivingSealedMethod : SealedMethodExample
    {
        // Now we can't override DoWork anymore.  
    }

}
