

using _02.Lunapark;
using System.Data;

string input = "";
LunaPark lunapark = new LunaPark();

while ((input = Console.ReadLine()) != "EXIT")
{
    var lineTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string command = lineTokens[0];

    switch (command)
    {
        case "SETNAME":
            if (lineTokens.Length != 2)
            {
                Console.WriteLine("Invalid input for SETNAME command. Usage: SETNAME <parkName>");
                break;
            }
            string parkName = lineTokens[1];

            lunapark.Name = parkName;

            break;

        case "ADD":
            try
            {
                if (lineTokens.Length != 6)
                {
                    Console.WriteLine("Invalid input for ADD command. Usage: ADD <name> <type> <yearOpened> <price> <isForKids>");
                    break;
                }
                string name = lineTokens[1];
                string type = lineTokens[2];

                if (!int.TryParse(lineTokens[3], out int yearOpened)
                   || !double.TryParse(lineTokens[4], out double price)
                   || !bool.TryParse(lineTokens[5], out bool isForKids))
                {
                    Console.WriteLine("Invalid year opened, price, or isForKids. They must be numeric values.");
                    break;
                }

                Attraction attraction = new Attraction(name, type, yearOpened, price, isForKids);

                if (attraction != null)
                {
                    lunapark.AddAttraction(attraction);

                    Console.WriteLine($"Attraction added: {attraction.ToString()}");
                }
                else
                {
                    Console.WriteLine("Invalid command or parameters.");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            break;

        case "REMOVE":
            try
            {
                if(lineTokens.Length != 2)
                {
                    Console.WriteLine("Invalid command!");
                }

                string name = lineTokens[1];

                lunapark.RemoveAttraction(name);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            break;

        case "SHOWALL":
            lunapark.ShowAll();
            break;

        case "COUNTOLD":
            try
            {
                int year = int.Parse(lineTokens[1]);

                Console.WriteLine($"Attractions older than 10 years: {lunapark.CountOlderThan10(year)}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            break;

        case "KIDSLIST":

           var kidsAttractions = lunapark.GetKidsAttractionsSorted();

            if(kidsAttractions != null)
            {
                Console.WriteLine("Kids attractions:");
                foreach (string attraction in kidsAttractions)
                {
                    Console.WriteLine(attraction);
                }
            }
            else
            {
                Console.WriteLine("No kids attractions.");
            }

            break;

        case "MOSTEXPENSIVE":
            var mostExpensive = lunapark.GetMostExpensiveAttraction();

            if(mostExpensive != null)
            {
                Console.WriteLine($"{mostExpensive.ToString()}");
            }
            else
            {
                Console.WriteLine("No attractions available.");
            }

            break;

        case "TOTALINCOME":
            Console.WriteLine($"Total income if all used once: {lunapark.GetTotalIncomeIfAllUsedOnce():f2}");
            break;

        case "DEPR":
            try
            {
                string name= lineTokens[1];
                int year = int.Parse(lineTokens[2]);

                var attr = lunapark.GetByName(name);


                if (attr == null)
                {
                    Console.WriteLine("Attraction not found!");
                }
                else
                {
                    double depr = attr.CalculateDepreciation(year);
                    Console.WriteLine($"Depreciation for {name}: {depr}");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            break;

        case "EXIT":
            return;
            break;
    }
}