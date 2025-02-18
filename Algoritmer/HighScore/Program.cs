using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HighScore> HighScore = new List<HighScore>();

            HighScore.Add(new HighScore("Jane", 7));
            HighScore.Add(new HighScore("John", 8));
            HighScore.Add(new HighScore("Melanie", 9));
            HighScore.Add(new HighScore("Kevin", 4));
            HighScore.Add(new HighScore("Kenneth", 4));
            HighScore.Add(new HighScore("Anders", 3));
            HighScore.Add(new HighScore("Benny", 10));
            HighScore.Add(new HighScore("Anders", 10));
            HighScore.Add(new HighScore("Lars", 2));
            HighScore.Add(new HighScore("Mette", 1));

            HighScore.Sort();

            foreach (var item in HighScore)
            {
                Console.Write(item.score + ": ");
                Console.WriteLine(item.name);
            }

            Console.ReadKey();
        }
    }
}
