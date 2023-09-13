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
            

            score = 0;
            enemyValue = 250;
            name = "Lauralynn";
            gamertag = "StupidPieTrap";

            score+=enemyValue;

            Console.WriteLine("Score: " + score);

            Console.WriteLine(name + " " + gamertag);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
