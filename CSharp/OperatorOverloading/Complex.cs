using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.OperatorOverloading
{
    class Complex
    {
        private int real;
        private int imaginary;

        public int Real { get => real; }
        public int Imaginary { get => imaginary; }

        public Complex() { }

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return (c1.Real == c2.Real && c1.Imaginary == c2.Imaginary);
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return (c1.Real != c2.Real && c1.Imaginary != c2.Imaginary);
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, Imaginary));
        }
    }
}
