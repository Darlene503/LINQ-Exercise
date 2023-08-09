using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Mortal Kombat 12",
                "NBA 2k23",
                "Halo 2",
                "Grand Theft Auto 3",
                "Ninja Gaiden",
               
            };

            var orderedGames = videoGames.OrderBy(game => game.Length);

            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}











