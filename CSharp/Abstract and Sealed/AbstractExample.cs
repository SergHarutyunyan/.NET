using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Abstract_and_Sealed
{
    public abstract class AbstractShapeExample
    {
        private string id;
        public string Id { get => id; set => id = value; }

        public AbstractShapeExample(string s)
        {
            // calling the set accessor of the Id property.
            Id = s;
        }

        // Area is a read-only property - only a get accessor is needed:
        public abstract double Area
        {
            get;
        }
        /*
         When declaring an abstract property (such as Area in this example),
         you simply indicate what property accessors are available,
         but do not implement them. In this example, only a get accessor is available, so the property is read-only.
        */

        public override string ToString()
        {
            return Id + " Area = " + string.Format("{0:F2}", Area);
        }
    }

    public class Square : AbstractShapeExample
    {
        private int side;

        public Square(int side, string id)
        : base(id)
        {
            this.side = side;
        }

        public override double Area => side * side;
    }
}
