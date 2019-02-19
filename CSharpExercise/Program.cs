using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double radius;

            Console.Write("Enter radius：");
            userInput = Console.ReadLine();
            /* Converts to double type */
            radius = Convert.ToDouble(userInput);
            Console.WriteLine("You entered {0}", radius);
            Console.WriteLine("Area of Circle is {0}", areaOfCircle(radius));
            Console.WriteLine("Circumference of Circle is {0}", circumferenceOfCircle(radius));
            Console.WriteLine("Volume of Hemisphere is {0}", volumeOfHemisphere(radius));
            Console.WriteLine("Area of Triangle is {0}", areaOfTriangle(3,4,5));
        }

        public static double areaOfCircle(double r)
        {
            double Area = Math.PI * Math.Pow(r, 2);
            return Area;
        }

        public static double circumferenceOfCircle(double r)
        {
            double Cir = 2* Math.PI * r;
            return Cir;
        }

        public static double volumeOfHemisphere(double r)
        {
            double Vol = 4.0 / 3 * Math.PI * Math.Pow(r,3) / 2;//use 4.0 so that 4/3 is not 1
            return Vol;
        }

        public static double areaOfTriangle(int a, int b, int c)
        {
            double p = (a + b + c) / 2.0;
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Area;
        }
    }
}
