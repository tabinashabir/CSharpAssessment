using System;

namespace PrintingSumofDigitsofANumber
{
    class Program
    {
        static void PrintSum(int value)
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
        static void Main(string[] args)
        {
            int value;

        Start:
            Console.WriteLine("Enter the number");
            bool isValueConverted = int.TryParse(Console.ReadLine(), out value);

            if (isValueConverted == false)
            {
                Console.WriteLine("Please enter a valid number");
                goto Start;
            }
            else
            {
                PrintSum(value);
            }

        }
    }
}