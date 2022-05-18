using System;

namespace PrintingSumofDigitsofANumber
{
     public static class PrintingSumofDigitsofANumberClass
    {
        public static void PrintSum()
        {
            int value;

            bool isValue4Converted;

            Console.WriteLine("Enter the number for which you want to calculate the sum of digits:");
            do
            {
                isValue4Converted = int.TryParse(Console.ReadLine(), out value);
                if (isValue4Converted == false)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            } while (isValue4Converted == false);

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