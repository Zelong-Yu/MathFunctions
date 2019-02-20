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
            int userChoice = 0;
            do
            {
                userChoice = DisplayMenu();
            } while (userChoice < 1 || userChoice > 5);


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
            var solution = quadraticEqn(1, 3, 1);
            Console.WriteLine("Solutions are {0},{1}", solution.Item1, solution.Item2);
        }

        public static int DisplayMenu()
        {
            Console.WriteLine("Mathematical Formulas");
            Console.WriteLine();
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Circumference of Circle");
            Console.WriteLine("3. Volume of a hemisphere");
            Console.WriteLine("4. Area of triangle given the length of the sides");
            Console.WriteLine("5. Solving a quadratic equation");
            var result = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", result);
            return Convert.ToInt32(result);
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

        public static Tuple<double,double> quadraticEqn(int a, int b, int c)
        {
            double Delta = b * b - 4 * a * c;
            if (Delta >= 0)
            {
                double x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
                var tuple = new Tuple<double, double>(x1, x2);
                return tuple;
            }
            else
            {
                Console.WriteLine("No Real Solution.");
                return new Tuple<double, double>(0.0, 0.0);
            }
        }
    }
}
