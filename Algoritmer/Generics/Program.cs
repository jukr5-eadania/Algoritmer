using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "bruh";
            string secondString = "kop";
            int second = 321;

            Swap<string>(ref first, ref secondString);
            Swap2(first, second);
            Console.ReadKey();
        }

        /// <summary>
        /// Cannot swap different types??
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void Swap<T>(ref T first, ref T second)
        {
            Console.WriteLine($"First = {first}");
            Console.WriteLine($"Second = {second}");
            T tmp = first;
            first = second;
            second = tmp;
            Console.WriteLine($"First = {first}");
            Console.WriteLine($"Second = {second}");
        }


        /// <summary>
        /// Can swap different types but less optimal???
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void Swap2(object first, object second)
        {
            Console.WriteLine($"First = {first}");
            Console.WriteLine($"Second = {second}");
            object tmp = first;
            first = second;
            second = tmp;
            Console.WriteLine($"First = {first}");
            Console.WriteLine($"Second = {second}");
        }
    }
}
