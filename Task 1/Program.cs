using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersRow= new int[] { 1, 1, 2, 4, 7, 13, 24, 44, 81, 149 };

            for (int i = 0; i < numbersRow.Length; i++)
            {
                Console.WriteLine("Number {0} has index {1}", numbersRow[i], i);
            }

            Console.WriteLine("Enter the index by which you want to find the number of the sequence");

            string enterNumber = Console.ReadLine();
            int index = Convert.ToInt32(enterNumber);

            if ((index > 0) && (index < numbersRow.Length - 1))
            {
                Console.WriteLine("This number {0}", numbersRow.ElementAt(index));
            }
            else
            {
                Console.WriteLine("No item with this index");
            }

            Console.ReadKey();
        }

    }
}