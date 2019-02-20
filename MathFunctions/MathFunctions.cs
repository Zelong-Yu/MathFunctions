using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class MathFunctionsClass
    {
        //Square :: Double -> Double
        public double Square(double value)
        {
            return Math.Pow(value, 2);
        }

        public double Cube(double value)
        {
            return Math.Pow(value, 3);
        }

    }
}
