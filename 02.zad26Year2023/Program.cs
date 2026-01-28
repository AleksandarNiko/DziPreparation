
int n =int.Parse(Console.ReadLine()!);

var pointsList = new List<double>();

try
{
    if (n < 3 || n > 10000 || char.IsDigit((char)n) != true)
    {
        throw new ArgumentOutOfRangeException("Incorrectly entered number");
    }

    ReadPoints(n);

    var validPointsCount = pointsList.Count(p => p > 0);
    Console.WriteLine($"{validPointsCount}");

    Console.WriteLine($"{MinDpoints():f3}");

    Console.WriteLine($"{Laureates()}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

void ReadPoints(int n)
{
    for (int i = 0; i < n; i++)
    {
        double currPoints = double.Parse(Console.ReadLine()!);

        if(currPoints < -100 && currPoints > 100)
        {
            throw new ArgumentOutOfRangeException("Incorrectly entered number");
        }

        pointsList.Add(currPoints);
    }
}

double MinDpoints()
{
    var validPoints = pointsList.Where(p => p > 0)
        .Distinct()
        .ToList();

    validPoints.Sort();
    double minDiff = double.MaxValue;

    for (int i = 1; i < validPoints.Count; i++)
    {
        double diff = validPoints[i] - validPoints[i - 1];
        if (diff < minDiff)
        {
            minDiff = diff;
        }
    }
    return minDiff == double.MaxValue ? 0 : minDiff;
}

int Laureates()
{
    var topScores = pointsList
        .Where(p => p > 0)
        .Distinct()
        .OrderByDescending(p => p)
        .Take(3)
        .ToList();
    if (topScores.Count < 3)
    {
        return pointsList.Count(p => p > 0);
    }
    double thirdHighestScore = topScores[2];
    int laureatesCount = pointsList
        .Count(p => p >= thirdHighestScore && p > 0);
    return laureatesCount;
}