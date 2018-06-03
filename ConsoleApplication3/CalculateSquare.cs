using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class CalculateSquare
    {
        double pi = Math.PI, S = 0;

        public Double Circle(Double b)
        {
            S = pi * b * b;
            return S;
        }

        public Double Triangle (Double a1, Double b1, Double c1)
        {
            Double p = (a1 + b1 + c1) / 2;
            S = Math.Sqrt(p * (p - a1) * (p - b1) * (p - c1));
            return S;
        }
    }
}
