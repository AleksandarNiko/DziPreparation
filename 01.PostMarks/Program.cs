
using _01.PostMarks;

StampCollector collector = new StampCollector("Mark Philatelic", 3700);

string input;

using(var reader = new StreamReader("input.txt"))
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

            case "BuyStamp":
                try
                {
                    string name = lineToken[1];
                    int year = int.Parse(lineToken[2]);
                    int rarity = int.Parse(lineToken[3]);
                    Stamp stamp = new Stamp(name, year, rarity);
                    collector.BuyStamp(stamp);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                break;

                case "GetStampsFromYear":

                try
                {
                    int targetYear = int.Parse(lineToken[1]);
                    var stampsFromYear = collector.GetStampsFromYear(targetYear);
                    if (stampsFromYear.Any())
                    {
                        Console.WriteLine($"Stamps from the year {targetYear}:");
                        Console.WriteLine($"{string.Join(", ", stampsFromYear)}");
                    }
                    else
                    {
                        Console.WriteLine($"No stamps from the year {targetYear}.");
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