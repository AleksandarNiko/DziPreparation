using System;
using System.Collections.Generic;
using System.Text;

namespace _01.VideoGames
{
    public class GameCollector : Gamer
    {
        private List<Game> games;

        public GameCollector(string name, double budget)
            : base(name, budget)
        {
            games = new List<Game>();
        }

        public override double CalculateSum()
        {
            return games.Count > 0 ? games.Sum(g => g.CalculatePrice()) : 0;
        }

        public void BuyGame(Game game)
        {
            double price = game.CalculatePrice();
            if (Budget >= price)
            {
                games.Add(game);
                Budget -= price;
                Console.WriteLine($"The game {game.Title} has been purchased. ");
            }
            else
            {
                throw new ArgumentException($"{price - Budget:F2} leva more to purchase the game {game.Title}.");
            }
        }

        public List<string> GetGamesFromYear(int year)
        {
            List<string> gamesFromYear = new List<string>();
            foreach (var game in games)
            {
                if (game.ReleaseYear == year)
                {
                    gamesFromYear.Add(game.Title);
                }
            }

            return gamesFromYear.OrderBy(s => s).ToList();
        }

        public string DescribeCollection()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The collector {Name} owns the following games:");
            foreach (var game in games)
            {
                sb.AppendLine(game.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }
}
