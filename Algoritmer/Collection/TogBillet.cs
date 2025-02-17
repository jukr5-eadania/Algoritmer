using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Tester")]

namespace TogBillet
{
    internal class TogBillet
    {
        public int BilletPris(int age)
        {
            switch (age)
            {
                case <= 1:
                    return 0;

                case >= 2 and <= 14:
                    return 10;

                case >= 15 and <= 64:
                    return 20;

                case >= 65:
                    return 5;
            }
        }
    }
}
