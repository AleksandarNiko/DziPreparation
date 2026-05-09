
using _01.VideoGames;

GameCollector collector = new GameCollector("Alex Gamer", 4000);

string input;

using (var reader = new StreamReader("input.txt"))
{
    while ((input = reader.ReadLine()) != "End")
    {
        string[] lineToken = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string command = lineToken[0];

        switch (command)
        {
            case "AddToBudget":
                try
                {
                    double amount = double.Parse(lineToken[1]);
                    collector.AddToBudget(amount);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                break;

            case "BuyGame":
                try
                {
                    string title = lineToken[1];
                    int year = int.Parse(lineToken[2]);
                    int rating = int.Parse(lineToken[3]);
                    Game game = new Game(title, year, rating);
                    collector.BuyGame(game);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                break;

            case "GetGamesFromYear":

                try
                {
                    int targetYear = int.Parse(lineToken[1]);
                    var gamesFromYear = collector.GetGamesFromYear(targetYear);
                    if (gamesFromYear.Any())
                    {
                        Console.WriteLine($"Games from the year {targetYear}:");
                        Console.WriteLine($"{string.Join(", ", gamesFromYear)}");
                    }
                    else
                    {
                        Console.WriteLine($"No games from the year {targetYear}.");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                break;

            case "CalculateSum":

                try
                {
                    double totalValue = collector.CalculateSum();
                    Console.WriteLine($"{totalValue:F2}");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                break;

            case "DescribeCollection":

                try
                {
                    Console.WriteLine(collector.DescribeCollection());
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                break;
        }
    }
}
