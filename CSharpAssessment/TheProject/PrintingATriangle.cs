using System;

namespace PrintingATriangle
{
    public static class PrintingATriangleClass
    {
        public static void PrintTriangle(int value, int width)
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
        

        
    }
}