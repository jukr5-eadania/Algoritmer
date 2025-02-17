using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("CalculatorTest")]

namespace Calculator
{
    internal class Calculator
    {
        public float Add(float first, float second)
        {
            return first + second;
        }
    }
}
