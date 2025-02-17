using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Tester")]

namespace Collection
{
    internal class Calculator
    {
        public float Add(float first, float second)
        {
            return first + second;
        }
    }
}