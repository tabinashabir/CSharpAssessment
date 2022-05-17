using System;

namespace PrintingSumofDigitsofANumber
{
     public static class PrintingSumofDigitsofANumberClass
    {
        public static void PrintSum(int value)
        {
            int myDigit = 0;
            int length = value.ToString().Length;
            for (int i = 1; i <= length; i++)
            {
                myDigit = myDigit + (value % 10);
                value = value / 10;
            }
            Console.WriteLine(myDigit);
        }
        
    }
}