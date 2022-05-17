using System;

namespace PrintingAPyramid
{
    public static class PrintingAPyramidClass
    {
        public static void PrintPyramid(int height)
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
        
    }
}