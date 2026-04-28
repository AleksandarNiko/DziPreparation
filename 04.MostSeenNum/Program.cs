
try
{
    int n;

    if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 1000)
    {
        throw new ArgumentException("Invalid input.");
    }

    var grades = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    if (grades.Count != n)
    {
        throw new ArgumentException("Invalid input.");
    }

    //var mostSeenNum = grades
    //    .GroupBy(x => x)
    //    .OrderByDescending(g => g.Count())
    //    .ThenBy(g => g.Key)
    //    .First()
    //    .Key;
    
    //Console.WriteLine(mostSeenNum);

    var numSeens = new Dictionary<int, int>();

    foreach (var grade in grades)
    {
        if (!numSeens.ContainsKey(grade))
        {
            numSeens.Add(grade,1);
        }

        numSeens[grade]++;
    }
    var mostSeenNum = numSeens
        .OrderByDescending(x => x.Value)
        .ThenBy(x => x.Key)
        .First()
        .Key;
    Console.WriteLine(mostSeenNum);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

/*
7
1 2 2 3 3 3 2
*/