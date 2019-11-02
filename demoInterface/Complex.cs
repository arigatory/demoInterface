using System;

namespace demoInterface
{
    public class Complex : IComparable<Complex>
    {
        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }
        public double Re { get; set; }
        public double Im { get; set; }
        public int CompareTo(Complex other)
        {
            if (other.Re < Re) return 1;
            if (other.Re > Re) return -1;
            return 0;
        }

        public override string ToString()
        {
            return $"{Re}+{Im}i";
        }
    }
}
