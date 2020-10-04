using System;

namespace SENG8040_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("--------Assignment 1---------");
                Console.WriteLine("1 - Enter Triangle Dimensions");
                Console.WriteLine("2 - Exit\n");
                Console.WriteLine("Please enter an option number:");
                userInput = Console.ReadLine();

                //Check if the user enters invalid entry
                if (userInput != "1" && userInput != "2")
                {
                    Console.WriteLine("Please enter a valid menu Option: \n");
                }

                //When user enters 1
                else if(userInput == "1")
                {
                    
                    Console.WriteLine("Please Enter 3 integers to check if it forms a triangle:");
                    Console.WriteLine("Enter first integer :");

                    //Check the first value is a valid number
                    string avalue = Console.ReadLine();
                    int a;
                    while (!int.TryParse(avalue, out a))
                    {
                        Console.WriteLine("Not a valid integer Number, enter again");
                        avalue = Console.ReadLine();
                    }

                    Console.WriteLine("Enter second integer :");

                    //Check the second value is a valid number
                    string bvalue = Console.ReadLine();
                    int b;
                    while (!int.TryParse(bvalue, out b))
                    {
                        Console.WriteLine("Not a valid integer Number, enter again");
                        bvalue = Console.ReadLine();
                    }

                    Console.WriteLine("Enter third integer :");

                    //Check the third value is a valid number
                    string cvalue = Console.ReadLine();
                    int c;
                    while (!int.TryParse(cvalue, out c))
                    {
                        Console.WriteLine("Not a valid integer Number, enter again");
                        cvalue = Console.ReadLine();
                    }

                    //Calling from the TriangleSolver class
                    string triangleCategory = TriangleSolver.Analyze(a, b, c);
                    Console.WriteLine(triangleCategory);

                    validMenuSelect = true;
                }

                //When the user enters the exit option
                else
                {
                    validMenuSelect = true;
                    Console.WriteLine("");
                    Console.WriteLine("Good Day!");
                }
            }
            Console.WriteLine();
        }
    }
}
