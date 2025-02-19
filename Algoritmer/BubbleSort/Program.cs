using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BubbleSort:");
            int[] numberArray = new int[10] { 7, 332, 91, 2, 3, 73, 19, 96, 1, 75 };
            Console.WriteLine("The original Array of numbers is: ");
            foreach (var item in numberArray)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            numberArray = BubbleSort(numberArray);

            Console.WriteLine("The sorted array of numbers is: ");
            foreach (var item in numberArray)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadKey();
        }

        static int[] BubbleSort(int[] l)
        {
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < l.Length; i++)
                {
                    if (l[i - 1] > l[i])
                    {
                        int tmp = l[i];
                        l[i] = l[i - 1];
                        l[i - 1] = tmp;
                        swapped = true;
                    }
                }
            }

            return l;
        }
    }
}
