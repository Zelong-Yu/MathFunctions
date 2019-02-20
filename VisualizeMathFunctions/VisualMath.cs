using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathFunctions;

namespace VisualizeMathFunctions
{
    class VisualMath
    {
        static void Main(string[] args)
        {
            //MathFunctionsClass mathFunctions = new MathFunctionsClass();
            Console.WriteLine($"The value of 2pi squared is: {MathFunctionsClass.Square(2*Math.PI):F3}"); //F3 displays only 3 digits after decimal point
            Console.Write("Enter radius：");
            string userInput;
            double radius;
            userInput = Console.ReadLine();
            // Converts to double type 
            radius = Convert.ToDouble(userInput);
            Console.WriteLine("You entered {0}", radius);
            Console.WriteLine("Area of Circle is {0}", MathFunctionsClass.areaOfCircle(radius));
            Console.WriteLine("Circumference of Circle is {0:F4}", MathFunctionsClass.circumferenceOfCircle(radius));
            Console.WriteLine("Volume of Hemisphere is {0}", MathFunctionsClass.volumeOfHemisphere(radius));
            Console.WriteLine("Area of Triangle is {0}", MathFunctionsClass.areaOfTriangle(3, 4, 5));
            var solution = MathFunctionsClass.quadraticEqn(1, 3, 1);
            Console.WriteLine("Solutions are {0},{1}", solution.Item1, solution.Item2);
        }
    }
}
