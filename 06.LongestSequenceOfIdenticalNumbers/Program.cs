
try
{

    int n;

    if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 1000)
    {
        throw new ArgumentException("Invalid input.");
    }

    var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    if (nums.Length != n)
    {
        throw new ArgumentException("Invalid input.");
    }

    var longestSequence = 1;
    var currentSequence = 1;

    int startIndex = 0;
    int endIndex = 0;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == nums[i - 1])
        {
            currentSequence++;
            if (currentSequence > longestSequence)
            {
                longestSequence = currentSequence;
                startIndex = i - longestSequence + 1;
                endIndex = i;
            }
        }
        else
        {
            currentSequence = 1;
        }
    } 

    Console.WriteLine("Length: {0}", longestSequence);
    Console.WriteLine("Value: {0}", nums[startIndex]);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

/*
10
1 1 2 2 2 3 3 3 3 2
*/
