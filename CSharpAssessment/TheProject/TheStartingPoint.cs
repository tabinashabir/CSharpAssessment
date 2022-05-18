using System;
using PrintingTableofANumber;
using PrintingSumofDigitsofANumber;
using PrintingATriangle;
using PrintingAPyramid;

namespace TheProject
{
    class TheStartingPoint
    {
        static void Main(string[] args)
        {

            string? exitChoice = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to my program! Please choose what problem you'd like to explore");
                Console.WriteLine("\nEnter 1 for printing a triangle\nEnter 2 for printing table of a number\nEnter 3 for printing a pyramid\nEnter 4 for printing sum of digits of a number\n");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintingATriangle.PrintingATriangleClass.PrintTriangle();
                        break;

                    case "2":                  
                        PrintingTableofANumber.PrintingTableofANumberClass.PrintTable();
                        break;

                    case "3":
                        PrintingAPyramid.PrintingAPyramidClass.PrintPyramid();
                        break;

                    case "4":
                        PrintingSumofDigitsofANumber.PrintingSumofDigitsofANumberClass.PrintSum();
                        break;

                    default:
                        Console.WriteLine("This is out of scope. Wait while we add new features as per your expectations. Till then..");
                        break;
                }

                do
                {
                    Console.WriteLine("\nDo you want to continue exploring the project? Yes/No");
                    exitChoice = Console.ReadLine();
                    if (exitChoice != "Yes" && exitChoice != "No")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No");
                    }
                } while (exitChoice != "Yes" && exitChoice != "No");

            } while (exitChoice == "Yes");

        }

    }
}
