using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QuickSort:");
            int[] numberArray = new int[10] { 7, 332, 91, 2, 3, 73, 19, 96, 1, 75 };
            Console.WriteLine("The original Array of numbers is: ");
            foreach (var item in numberArray)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            numberArray = QuickSort(numberArray);

            Console.WriteLine("The sorted array of numbers is: ");
            foreach (var item in numberArray)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadKey();
        }

        static int[] QuickSort(int[] l)
        {

        }
    }
}
