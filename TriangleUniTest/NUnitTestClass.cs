using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using SENG8040_Assignment1;

namespace TriangleUniTest
{
    [TestFixture]
    class NUnitTestClass
    {
        [TestCase]
        public void Analyze_InputtingEqualValues_EquilateralTriangle()
        {
            //Arrange
            int side1 = 3;
            int side2 = 3;
            int side3 = 3;

            //Act
            string checkEquilateralTriangle = TriangleSolver.Analyze(side1, side2, side3);
            
            //Assert
            Assert.AreEqual("The entered integers forms an Equilateral Triangle!",checkEquilateralTriangle);
        }

        [TestCase]
        public void Analyze_InputtingTwoEqualValues_IsoscelesTriangle()
        {
            //Arrange
            int side1 = 3;
            int side2 = 3;
            int side3 = 5;

            //Act
            string checkIsocelesTriangle = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual("The entered integers forms an Isosceles Triangle!", checkIsocelesTriangle);
        }

        [TestCase]
        public void Analyze_InputtingThreeDifferentValues_ScaleneTriangle()
        {
            //Arrange
            int side1 = 3;
            int side2 = 2;
            int side3 = 4;

            //Act
            string checkScaleneTriangle = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual("The entered integers forms an Scalene Triangle!", checkScaleneTriangle);
        }

        [TestCase]
        public void Analyze_SumOfTwoSmallestEqualsTheLargestToTriangle_NotAValidTriangle()
        {
            //Arrange
            int side1 = 8;
            int side2 = 3;
            int side3 = 5;

            //Act
            string checkNotATriangle = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual("It does not form a Triangle! ", checkNotATriangle);
        }

        [TestCase]
        public void Analyze_SumOfTwoSmallestLessThanTheLargestToTriangle_NotAValidTriangle()
        {
            //Arrange
            int side1 = 8;
            int side2 = 2;
            int side3 = 5;

            //Act
            string checkNotATriangle = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual("Not a Triangle! ", checkNotATriangle);
        }

        [TestCase]
        public void Analyze_InputtingOneZeroValueToTriangle_NotAValidTriangle()
        {
            //Arrange
            int side1 = 0;
            int side2 = 3;
            int side3 = 5;

            //Act
            string checkNotATriangle = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual("Not a Triangle: Triangle lengths should not have any 0 values", checkNotATriangle);
        }

        [TestCase]
        public void Analyze_InputtingAllZeroValuesToTriangle_NotAValidTriangle()
        {
            //Arrange
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;

            //Act
            string checkNotATriangle = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual("Not a Triangle: Triangle lengths should not have any 0 values", checkNotATriangle);
        }

        [TestCase]
        public void Analyze_InputtingSumOfTwoNumbersEqualtoOtherToTriangle_NotAValidTriangle()
        {
            //Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 10;

            //Act
            string checkNotATriangle = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual("Not a Triangle: Sum of two Triangle lengths should not be equal to the other length value", checkNotATriangle);
        }

    }
}
