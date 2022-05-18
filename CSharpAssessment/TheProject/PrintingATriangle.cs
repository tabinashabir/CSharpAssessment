using System;

namespace PrintingATriangle
{
    public static class PrintingATriangleClass
    {
        public static void PrintTriangle()
        {
            int value;
            int width;

            bool isValue1Converted;
            bool isWidthConverted;

            Console.WriteLine("Enter the number:");
            do
            {
                isValue1Converted = int.TryParse(Console.ReadLine(), out value);
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

            do
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write(value);
                }
                Console.WriteLine();
                width = width - 1;
            } while (width > 0);

        }  
    }
}