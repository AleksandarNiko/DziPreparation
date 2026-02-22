

try
{
    int numsCount = int.Parse(Console.ReadLine());

    var wordCounts = new Dictionary<int, int>();

    for (int i = 0; i < numsCount; i++)
    {
        int num = int.Parse(Console.ReadLine());
        if (!wordCounts.ContainsKey(num))
        {
            wordCounts[num] = 0;
        }
        wordCounts[num]++;
    }

    foreach (var kvp in wordCounts)
    {
        Console.WriteLine($"число: {kvp.Key}, брой: {kvp.Value}");
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
