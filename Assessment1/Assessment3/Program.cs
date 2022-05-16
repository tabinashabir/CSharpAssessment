using System;

namespace PrintingAPyramid
{
    class Program
    {
        static void PrintPyramid(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                int space = height - i;
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int height;

        Start:
            Console.WriteLine("Enter the height of the pyramid");
            bool isValueConverted = int.TryParse(Console.ReadLine(), out height);

            if (isValueConverted == false)
            {
                Console.WriteLine("Please enter a valid number");
                goto Start;
            }
            else
            {
                PrintPyramid(height);
            }

        }
    }
}