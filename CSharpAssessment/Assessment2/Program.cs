using System;

namespace PrintingTableofANumber
{
    class Program
    {
        static void PrintTable(int value, int point)
        {
            for (int i = 1; i <= point; i++)
            {
                Console.WriteLine("{0} x {1} = {2} ", value, i, value * i);
            }
        }
        static void Main(string[] args)
        {
            int value;
            int point;

        Start:
            Console.WriteLine("Enter the number:");
            bool isValueConverted = int.TryParse(Console.ReadLine(), out value);

            if (isValueConverted)
            {
                StartAgain:
                    Console.WriteLine("Enter the number you want to print the table upto:");
                    bool isWidthConverted = int.TryParse(Console.ReadLine(), out point);


                    if (isWidthConverted == false)
                    {
                        Console.WriteLine("Please enter a valid number");
                        goto StartAgain;
                    }

                    else
                    {
                        PrintTable(value, point);
                    }

            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                goto Start;
            }


        }
    }
}