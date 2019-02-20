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
            MathFunctionsClass mathFunctions = new MathFunctionsClass();
            Console.WriteLine($"The value of pi cubed is: {mathFunctions.Cube(Math.PI):F3}"); //F3 displays only 3 digits after decimal point
        }
    }
}
