using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SENG8040_Assignment1
{
    public static class TriangleSolver
    {
        static TriangleSolver()
        {
        }
        public static string Analyze(int value1, int value2, int value3)
        {
            //Check if the values form a triangle that is scalene, isosceles, or equilateral
            //Logic for entering 0 values to the side lengths
            if (value1 == 0 || value2 == 0 || value3 == 0)
            {
                string str = "Not a Triangle: Triangle lengths should not have any 0 values";
                return str;
            }

            //Logic for equilateral Triangle
            else if (value1 == value2 && value2 == value3)
            {
                string str = "The entered integers forms an Equilateral Triangle!";
                return str;
            }

            //Logic for sum of two side lengths getting equal to the other side length
            else if (value1 + value2 == value3 || value1 + value3 == value2 || value3 + value2 == value1)
            {
                string str = "Not a Triangle: Sum of two Triangle lengths should not be equal to the other length value";
                return str;
            }

            //Logic for Isoceles Triangle
            else if (value1 == value2 || value2 == value3 || value3 == value1)
            {
                string str = "The entered integers forms an Isosceles Triangle!";
                return str;
            }

            //Logic for Scalene Triangle
            else if (value1 + value2 > value3 && value1 + value3 > value2 && value2 + value3 > value1)
            {
                string str = "The entered integers forms an Scalene Triangle!";
                return str;
            }

            //When the entered values doesn't form a triangle
            else
            {
                string str = "It does not form a Triangle! ";
                return str;
            }
        }
    }
}
