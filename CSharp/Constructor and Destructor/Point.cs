using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Constructor_and_Destructor
{
    enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }
        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }
        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }
        public Point()
        : this(PointColor.BloodRed) { }
       
        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is {0}", Color);
        }
    }

    class DestructorExample
    {
        private int x, y;

        public DestructorExample()
        {
            Console.WriteLine("Constructor called");
            x = 7;
            y = 8;
        }

        ~DestructorExample()
        {
            Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine("Fields cleaned");
            x = 0;
            y = 0;
        }
    }
}
