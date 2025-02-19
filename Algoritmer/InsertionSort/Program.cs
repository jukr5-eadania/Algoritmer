using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[10] { 7, 332, 91, 2, 3, 73, 19, 96, 1, 75 };
            Console.WriteLine("The original Array of numbers is: ");
            foreach (var item in numberArray)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            numberArray = InsertionSort(numberArray);

            Console.WriteLine("The sorted array of numbers is: ");
            foreach (var item in numberArray)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadKey();
        }

        static int[] InsertionSort(int[] l)
        {
            for (int i = 1; i < l.Length - 1; i++)
            {
                int val = l[i];
                int pointer = i;
                while (pointer > 0 && val < l[pointer - 1])
                {
                    l[pointer] = l[pointer - 1];
                    pointer = pointer - 1;
                }
                l[pointer] = val;
            }

            return l;
        }
    }
}
