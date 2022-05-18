using System;

namespace PrintingAPyramid
{
    public static class PrintingAPyramidClass
    {
        public static void PrintPyramid()
        {
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
        
    }
}