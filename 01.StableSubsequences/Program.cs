
try
{
    int n,k;

    if(!int.TryParse(Console.ReadLine(), out n) || n < 3)
    {
        throw new ArgumentException("Invalid n!");
    }

    var numsArray = new int[n];

    for(int i = 0; i < numsArray.Length; i++)
    {
        numsArray[i] = int.Parse(Console.ReadLine());
    }

    if (!int.TryParse(Console.ReadLine(), out k) || k < 2)
    {
        throw new ArgumentException("Invalid k!");
    }

    StableSubsequences(numsArray, k);

}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

static void StableSubsequences(int[] numsArray, int k)
{
    var stableSubsequences = new List<List<int>>();

    int i = 0;
    while (i < numsArray.Length - 1)
    {
        int j = i + 1;
        while (j < numsArray.Length && Math.Abs(numsArray[j] - numsArray[j - 1]) <= k)
        {
            j++;
        }

        int length = j - i;
        if (length >= 2)
        {
            var subseq = new List<int>();
            for (int t = i; t < j; t++) subseq.Add(numsArray[t]);
            stableSubsequences.Add(subseq);
        }

        if (j == i + 1)
        {
            i++;
        }
        else
        {
            i = j;
        }
    }

    Console.WriteLine("1 count- {0}", stableSubsequences.Count);
    Console.WriteLine("2 -");
    foreach (var subsequence in stableSubsequences)
    {
        Console.WriteLine(string.Join(" ", subsequence));
    }

    if (stableSubsequences.Count == 0)
    {
        Console.WriteLine("3 - maxLength- 0");
        Console.WriteLine("4 - maxSum- 0");
        return;
    }

    int maxLength = stableSubsequences.Max(s => s.Count);
    int maxSum = stableSubsequences.Max(s => s.Sum());

    Console.WriteLine("3 - maxLength- {0}", maxLength);
    Console.WriteLine("4 - maxSum- {0}", maxSum);
}

/*
8
1
3
5
4
10
11
12
2
2
*/