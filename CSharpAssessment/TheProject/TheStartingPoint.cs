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
            Console.WriteLine("Welcome to my program! Please choose what problem you'd like to explore");
            do
            {
                Console.WriteLine("\nEnter 1 for printing a triangle\nEnter 2 for printing table of a number\nEnter 3 for printing a pyramid\nEnter 4 for printing sum of digits of a number");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        int value1 = 0;
                        int width = 0;
                        bool isValue1Converted;
                        bool isWidthConverted;
                        Console.WriteLine("Enter the number:");
                        do
                        {
                            isValue1Converted = int.TryParse(Console.ReadLine(), out value1);
                            if (isValue1Converted == false)
                            {
                                Console.WriteLine("Please enter a valid number");
                            }
                        } while (isValue1Converted == false);
                        Console.WriteLine("Enter the width of the triangle:");
                        do
                        {
                            isWidthConverted = int.TryParse(Console.ReadLine(), out width);
                            if (isWidthConverted == false)
                            {
                                Console.WriteLine("Please enter a valid number");
                            }
                        } while (isWidthConverted == false);

                        PrintingATriangle.PrintingATriangleClass.PrintTriangle(value1, width);

                        break;

                    case "2":
                        int value2;
                        int point;
                        bool isValue2Converted;
                        bool isPointConverted;
                        Console.WriteLine("Enter the number");
                        do
                        {
                            isValue2Converted = int.TryParse(Console.ReadLine(), out value2);
                            if (isValue2Converted == false)
                            {
                                Console.WriteLine("Please enter a valid number");
                            }
                        } while (isValue2Converted == false);
                        Console.WriteLine("Enter the number you want to print the table upto:");
                        do
                        {
                            isPointConverted = int.TryParse(Console.ReadLine(), out point);
                            if (isPointConverted == false)
                            {
                                Console.WriteLine("Please enter a valid number");
                            }

                        } while (isPointConverted == false);

                        PrintingTableofANumber.PrintingTableofANumberClass.PrintTable(value2, point);
                        
                        break;

                    case "3":
                        int height;
                        bool isValue3Converted;
                        Console.WriteLine("Enter the height of the pyramid");
                        do
                        {
                            isValue3Converted = int.TryParse(Console.ReadLine(), out height);
                            if (isValue3Converted == false)
                            {
                                Console.WriteLine("Please enter a valid number");
                            }
                        } while (isValue3Converted == false);

                        PrintingAPyramid.PrintingAPyramidClass.PrintPyramid(height);

                        break;

                    case "4":
                        int value4;
                        bool isValue4Converted;
                        Console.WriteLine("Enter the number for which you want to calculate the sum of digits:");
                        do
                        {
                            isValue4Converted = int.TryParse(Console.ReadLine(), out value4);
                            if (isValue4Converted == false)
                            {
                                Console.WriteLine("Please enter a valid number");
                            }
                        } while (isValue4Converted == false);

                        PrintingSumofDigitsofANumber.PrintingSumofDigitsofANumberClass.PrintSum(value4);

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
