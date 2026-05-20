
using _01.SoftwareCatalogue;

int appsCount = int.Parse(Console.ReadLine());
var apps = new List<App>();

for (int i = 0; i < appsCount; i++)
{
    string[] appInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = appInfo[0];
    string category = appInfo[1];
    double rating = double.Parse(appInfo[2]);
    int downloads = int.Parse(appInfo[3]);
    decimal price = decimal.Parse(appInfo[4]);
    App app = new App
    {
        Name = name,
        Category = category,
        Rating = rating,
        Downloads = downloads,
        Price = price
    };
    apps.Add(app);
}

string categoryToSearch = Console.ReadLine();

var filteredApps = apps.Where(a => a.Category == categoryToSearch)
    .OrderByDescending(a => a.Rating)
    .ThenByDescending(a => a.Downloads)
    .ToList();

var downloadsSum = filteredApps.Sum(a => a.Downloads);

if (filteredApps.Any())
{
    foreach (var app in filteredApps)
    {
        Console.WriteLine($"{app.Name} - Рейтинг: {app.Rating:f1}");
    }
    Console.WriteLine($"Общ брой изтегляния: {downloadsSum}");
}
else
{
    Console.WriteLine($"Няма намерени приложения");
}

/*
4
Duolingo Образование 4,7 500000 0,0
Minecraft Игри 4,8 1000000 12,99
Anki Образование 4,5 50000 0,0
Coursera Образование 4,7 200000 0,0
Образование
*/