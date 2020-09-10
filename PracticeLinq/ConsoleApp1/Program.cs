using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> GameList = new List<string> { "Sonic The Hedgehog", "Donkey Kong", "Final Fantasy", "R-Type", "Hyperdimension Neptunia" };
            var length = GameList.OrderBy(name => name.Length);

            foreach (var game in length)
            {
                Console.WriteLine(game);
            }

        }
    }
}
