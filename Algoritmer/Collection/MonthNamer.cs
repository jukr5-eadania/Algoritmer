using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Tester")]

namespace Collection
{
    internal class MonthNamer
    {
        public string NameMonth(int number)
        {
            switch (number)
            {
                case 1:
                    return "January";

                case 2:
                    return "Febuary";

                case 3:
                    return "March";

                case 4:
                    return "April";

                case 5:
                    return "May";

                case 6:
                    return "June";

                case 7:
                    return "July";

                case 8:
                    return "August";

                case 9:
                    return "September";

                case 10:
                    return "October";

                case 11:
                    return "November";

                case 12:
                    return "December";

                default:
                    return "Number does not fit a month";
            }
        }
    }
}
