using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Nested_Types
{
    class Container
    {
        public int Pub;
        private int pri;
        protected int prot;

        private class PrivateNested
        {
            private Container parent;

            public PrivateNested(Container parent)
            {
                this.parent = parent;              
            }
        }

        public class PublicNested
        {
            private Container parent;

            public PublicNested(Container parent)
            {
                this.parent = parent;
            }

            public void Print()
            {
                Console.WriteLine(parent.Pub);
            }
        }
    }

    public class TestingNested
    {
        public TestingNested()
        {
            Container container = new Container();
            Container.PublicNested publicNested = new Container.PublicNested(container);


            // But PrivateNested is unaccessible
        }
    }
}
