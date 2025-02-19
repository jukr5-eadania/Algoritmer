using System;
using System.Collections.Generic;

namespace BeginnerAlgoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 6, 21, 73, 2, 882, 5, 83 };
            Console.WriteLine("The original list is: ");
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            int highestNumber = FindHighestNumber(list);
            Console.WriteLine($"Highest number is: {highestNumber}");

            List<int> oddNumberList = new List<int>();
            oddNumberList = OddNumbers(list);
            Console.WriteLine("The odd numbers are: ");
            foreach (var item in oddNumberList)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadLine();
        }


        static int FindHighestNumber(List<int> l)
        {

            int largest = l[0];
            foreach (var item in l)
            {
                if (item > largest)
                {
                    largest = item;
                }
            }

            return largest;
        }

        static List<int> OddNumbers(List<int> l)
        {
            List<int> oddNumberList = new List<int>();

            foreach (int number in l)
            {
                if (number % 2 == 0)
                {
                    //is even
                }
                else
                {
                    //is odd
                    oddNumberList.Add(number);
                }
            }

            return oddNumberList;
        }
    }
}
