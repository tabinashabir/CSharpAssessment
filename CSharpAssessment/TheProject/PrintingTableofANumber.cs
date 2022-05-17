using System;

namespace PrintingTableofANumber
{
    public static class PrintingTableofANumberClass
    {
        public static void PrintTable(int value, int point)
        {
            for (int i = 1; i <= point; i++)
            {
                Console.WriteLine("{0} x {1} = {2} ", value, i, value * i);
            }
        }
    }
}