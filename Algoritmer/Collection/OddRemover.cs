using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Tester")]

namespace Collection
{
    internal class OddRemover
    {

        public List<int> RemoveOddNumber(List<int> numbers)
        {
            List<int> oddLess = new();
            
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    oddLess.Add(number);
                    //is even
                }
                else
                {
                    //is odd
                    oddLess.Remove(number);
                }
            }

            return oddLess;
        }
    }
}
