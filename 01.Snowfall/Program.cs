
using _01.Snowfall;

Snowfall snowfall = new Snowfall();

//Console.WriteLine("----MENU----");
//Console.WriteLine("1) ADD <type> <size> <weight>");
//Console.WriteLine("2) COUNT");
//Console.WriteLine("3) PERM2 <area>");
//Console.WriteLine("4) INTENSITY <area>");
//Console.WriteLine("5) AVG_SPEED");
//Console.WriteLine("6) FASTEST");
//Console.WriteLine("7) LIST");
//Console.WriteLine("8) EXIT");
//Console.WriteLine("Choose option:");

string input = "";

while((input=Console.ReadLine()) != "EXIT")
{
    var lineTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string command = lineTokens[0];

    switch (command)
    {
        case "ADD":
            if(lineTokens.Length != 4)
            {
                Console.WriteLine("Invalid input for ADD command. Usage: ADD <type> <size> <weight>");
                break;
            }
            string type = lineTokens[1];
            if(!double.TryParse(lineTokens[2], out double size) 
                || !double.TryParse(lineTokens[3], out double weight))
            {
                Console.WriteLine("Invalid size or weight. They must be numeric values.");
                break;
            }

            Snowflake? snowflake = type switch
            {
                "CRYSTAL" => new CrystalSnowflake { Size = size, Weight = weight },
                "ICE" => new IceSnowflake { Size = size, Weight = weight },
                "FLUFFY" => new FluffySnowflake { Size = size, Weight = weight },
                _ => null
            };

            if (snowflake != null)
            {
                snowfall.AddSnowflake(snowflake);

                Console.WriteLine($"Added {snowflake.GetTypeName()} snowflake.");
            }
            else
            {
                Console.WriteLine("Invalid command or parameters.");
            }

            break;

            case "COUNT":
            Console.WriteLine($"Snowflakes: {snowfall.GetSnowflakeCount()}");
            break;

            case "PERM2":
            double area = lineTokens.Length == 2 && double.TryParse(lineTokens[1], out area) && area > 0
                ? area : 0;

            Console.WriteLine($"Snowflakes per m2: {snowfall.GetSnowflakesPerSquareMeter(area):f2}");

            break;

            case "INTENSITY":
            double currArea = lineTokens.Length == 2 && double.TryParse(lineTokens[1], out area) && area > 0
                ? area : 0;

            Console.WriteLine($"Intensity: {snowfall.GetIntensity(currArea)}");
            break;

        case "AVG_SPEED":

            if(snowfall.GetSnowflakeCount() == 0)
            {
                Console.WriteLine("No snowflakes");
            }
            else
            {
                Console.WriteLine($"Average falling speed: {snowfall.GetAverageFallingSpeed():f3} m/s");
            }

            break;

        case "FASTEST":

            if (snowfall.GetSnowflakeCount() == 0)
            {
                Console.WriteLine("No snowflakes");
            }
            else
            {
                var fastestSnowflake = snowfall.GetFastestSnowflake();
                Console.WriteLine($"Fastest: {fastestSnowflake.GetTypeName()} | Size={fastestSnowflake.Size:f2}mm | Weight={fastestSnowflake.Weight:f2}mg | Speed={fastestSnowflake.GetFallingSpeed():f3} m/s");
            }

            break;

        case "LIST":
            if (snowfall.GetSnowflakeCount() == 0)
            {
                Console.WriteLine("No snowflakes");
            }
            else
            {
                snowfall.GetSnowflakes();
            }
            break;
    }
}

/*
ADD CRYSTAL 2.5 4
ADD FLUFFY 5 3
ADD ICE 2 6
COUNT
PERM2 0.05
INTENSITY 0.05
ADD CRYSTAL 1 1.2
ADD ICE 3 3
COUNT
AVG_SPEED
ADD FLUFFY 8 4
ADD CRYSTAL 6 2
ADD ICE 4 10
COUNT
PERM2 0.05
INTENSITY 0.05
FASTEST
LIST
EXIT
*/

/*
ADD CRYSTAL 2,5 4
ADD FLUFFY 5 3
ADD ICE 2 6
COUNT
PERM2 0,05
INTENSITY 0,05
ADD CRYSTAL 1 1,2
ADD ICE 3 3
COUNT
AVG_SPEED
ADD FLUFFY 8 4
ADD CRYSTAL 6 2
ADD ICE 4 10
COUNT
PERM2 0,05
INTENSITY 0,05
FASTEST
LIST
EXIT
*/
