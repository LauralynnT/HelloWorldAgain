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

            score = 0;

            Console.WriteLine(score);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
