using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    internal class HighScore : IComparable<HighScore>
    {
        public string name;
        public int score;

        public HighScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public int CompareTo(HighScore other)
        {
            if (other.score > score)
            {
                return 1;
            }
            else if (other.score < score)
            {
                return -1;
            }
            else
            {
                return name.CompareTo(other.name);
            }
        }
    }
}
