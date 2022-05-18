using System;

namespace PrintingTableofANumber
{
    public static class PrintingTableofANumberClass
    {
        public static void PrintTable()
        {
            int value;
            int point;

            bool isValue2Converted;
            bool isPointConverted;

            Console.WriteLine("Enter the number");
            do
            {
                isValue2Converted = int.TryParse(Console.ReadLine(), out value);
                if (isValue2Converted == false)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            } while (isValue2Converted == false);

            Console.WriteLine("Enter the number you want to print the table upto:");
            do
            {
                isPointConverted = int.TryParse(Console.ReadLine(), out point);
                if (isPointConverted == false)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            } while (isPointConverted == false);
            for (int i = 1; i <= point; i++)
            {
                Console.WriteLine("{0} x {1} = {2} ", value, i, value * i);
            }
        }
    }
}