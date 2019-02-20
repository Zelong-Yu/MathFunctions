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
        MathFunctionsClass objectUnderTest = new MathFunctionsClass(); //declare and instantiaze MathFunctionsClass

        [TestMethod()]
        public void SquareTest()
        {
            Assert.AreEqual(36, objectUnderTest.Square(-6));
            Assert.AreEqual(0, objectUnderTest.Square(0));
            Assert.AreEqual(16, objectUnderTest.Square(4));
            /* objectUnderTest.Square(1)
                           .ShouldBe(1);
            objectUnderTest.Square(6)
                           .ShouldBe(36);*/ 
        }

        [TestMethod()]
        public void CubeTest()
        {
            Assert.AreEqual(8,objectUnderTest.Cube(2));
            /* objectUnderTest.Cube(2)
                           .ShouldBe(8);
            objectUnderTest.Cube(-2)
                           .ShouldBe(-8); */
        }
    }
}