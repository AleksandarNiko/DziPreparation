
using _06.zad28Year2023May;

var furnitures = new List<Furniture>();

string input = "";

while((input = Console.ReadLine()) != "END")
{
    var lineToken = input.Split(" ");

    if (lineToken.Length == 2)
    {
        var table = new Table(lineToken[0], double.Parse(lineToken[1]));
        furnitures.Add(table);
    }
    else if (lineToken.Length == 3) 
    {
        var cabinet = new Cabinet(lineToken[0], double.Parse(lineToken[1]), int.Parse(lineToken[2]));
        furnitures.Add(cabinet);
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}


var tables = furnitures
    .Where(f=>f is Table)
    .ToList();

Console.WriteLine("All tables:");
foreach (var table in tables)
{
    Console.WriteLine(table.ToString());
}

Console.WriteLine("All cabinets:");
var cabinets = furnitures
    .Where(f => f is Cabinet)
    .ToList();

foreach (var cabinet in cabinets)
{
    Console.WriteLine(cabinet.ToString());
}