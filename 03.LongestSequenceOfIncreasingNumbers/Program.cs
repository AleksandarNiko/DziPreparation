

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

    int maxLength = 1;
    int currentLength = 1;

    int bestStart = 0;
    int currentStart = 0;

    var longestSequence = new List<int>();


    for (int i = 1; i < grades.Count; i++)
    {
        if (grades[i] > grades[i - 1])
        {
            currentLength++;
        }
        else
        {
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                bestStart = currentStart;
            }

            currentLength = 1;
            currentStart = i;
        }
    }

    if (currentLength > maxLength)
    {
        maxLength = currentLength;
        bestStart = currentStart;
    }

    Console.WriteLine("Дължина: " + maxLength);

    Console.Write("Подредица: ");
    for (int i = bestStart; i < bestStart + maxLength; i++)
    {
        Console.Write(grades[i] + " ");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

/*
8
1 2 2 3 4 1 2 3
*/