using System;

namespace PrintingATriangle
{
    class Program
    {
        static void PrintTriangle(int value, int width)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write(value);
            }
            width = width - 1;

            if (width != 0)
            {
                Console.WriteLine();
                PrintTriangle(value, width);
            }
        }
        static void Main(string[] args)
        {
            int value = 0;
            int width = 0;

        Start:
            Console.WriteLine("Enter the number");
            bool isValueConverted = int.TryParse(Console.ReadLine(), out value);

            if (isValueConverted == false)
            {
                Console.WriteLine("Please enter a valid number");
                goto Start;
            }

        StartAgain:
            Console.WriteLine("Enter the width of the triangle");
            bool isWidthConverted = int.TryParse(Console.ReadLine(), out width);

            //bool isWidthConverted = int.TryParse(thewidth, out width);

            if (isWidthConverted == false)
            {
                Console.WriteLine("Please enter a valid number");
                goto StartAgain;
            }

            else
            {
                PrintTriangle(value, width);
            }

        }
    }
}