using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.WriteLine("---------");
            Console.WriteLine();

            int score;
            int enemyValue;
            string name;
            string gamertag;
            float percentile;

            score = 0;
            enemyValue = 250;
            name = "Lauralynn";
            gamertag = "StupidPieTrap";
            percentile = 80.48f;

            score+=enemyValue;
            percentile = (92043f / 380972f)*100f;

            Console.WriteLine("Score: " + score);
            Console.WriteLine("Percentile Rank: " + percentile + "%");
            Console.WriteLine(name + " " + gamertag);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
