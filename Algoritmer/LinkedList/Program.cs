using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(23);
            list.AddFirst(88);
            list.AddFirst(1230);
            list.AddLast(42);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
