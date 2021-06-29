using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>() { "Monkey Island", "Day of the Tentacle", "Sam and Max" };

            var sortedGames = games.OrderBy(game => game.Length);

            foreach (var game in sortedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
