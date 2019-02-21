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
        public static double Square(double value)
        {
            return Math.Pow(value, 2);
        }

        public static double Cube(double value)
        {
            return Math.Pow(value, 3);
        }

        public static double areaOfCircle(double r)
        {
            double Area = Math.PI * Math.Pow(r, 2);
            return Area;
        }

        public static double circumferenceOfCircle(double r)
        {
            double Cir = 2 * Math.PI * r;
            return Cir;
        }

        public static double volumeOfHemisphere(double r)
        {
            double Vol = 4.0 / 3 * Math.PI * Math.Pow(r, 3) / 2;//use 4.0 so that 4/3 is not 1
            return Vol;
        }

        public static double areaOfTriangle(int a, int b, int c)
        {
            double p = (a + b + c) / 2.0;
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Area;
        }

        public static (double, double) quadraticEqn(int a, int b, int c)
        {
            double Delta = b * b - 4 * a * c;
            if (Delta >= 0)
            {
                double x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
                var tuple = (x1, x2);
                return tuple;
            }
            else
            {
                Console.WriteLine("Discriminant is negative.");
                throw new ArithmeticException("No Real Solution since Discriminant<0");
            }
        }

    }
}
