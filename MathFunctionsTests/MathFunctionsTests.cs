using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace MathFunctions.Tests
{
    [TestClass()]
    public class MathFunctionsTests
    {
        //MathFunctionsClass objectUnderTest = new MathFunctionsClass(); //declare and instantiaze MathFunctionsClass

        [TestMethod()]
        public void AreaCirVolTest()
        {
            Assert.AreEqual(9 * Math.PI, MathFunctionsClass.areaOfCircle(3));
            Assert.AreEqual(6 * Math.PI, MathFunctionsClass.circumferenceOfCircle(3));
            Assert.AreEqual(56.54866776461, MathFunctionsClass.volumeOfHemisphere(3),0.000001);
            /* MathFunctionsClass.Square(1)
                           .ShouldBe(1);
            oMathFunctionsClass.Square(6)
                           .ShouldBe(36);*/
        }

        [TestMethod()]
        public void TriangleTest()
        {
            Assert.AreEqual(6, MathFunctionsClass.areaOfTriangle(3,4,5));
            /* MathFunctionsClass.Cube(2)
                           .ShouldBe(8);
            MathFunctionsClass.Cube(-2)
                           .ShouldBe(-8); */
        }
    }
}