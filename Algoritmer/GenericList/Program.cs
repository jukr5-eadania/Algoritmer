using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(6);
            list.Add(3);
            list.Add(1);
            list.Add(2);
            list.Add(8);
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine("eye: " + item);
            }
            Console.ReadLine();
        }
    }
}
