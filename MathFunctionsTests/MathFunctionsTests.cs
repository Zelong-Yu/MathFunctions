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
        public void SquareTest()
        {
            Assert.AreEqual(Math.PI, MathFunctionsClass.areaOfCircle(1));
            Assert.AreEqual(0, MathFunctionsClass.Square(0));
            Assert.AreEqual(16, MathFunctionsClass.Square(4));
            /* MathFunctionsClass.Square(1)
                           .ShouldBe(1);
            oMathFunctionsClass.Square(6)
                           .ShouldBe(36);*/
        }

        [TestMethod()]
        public void CubeTest()
        {
            Assert.AreEqual(8, MathFunctionsClass.Cube(2));
            /* MathFunctionsClass.Cube(2)
                           .ShouldBe(8);
            MathFunctionsClass.Cube(-2)
                           .ShouldBe(-8); */
        }
    }
}