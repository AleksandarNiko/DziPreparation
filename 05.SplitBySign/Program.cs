
try
{
    int n;

    if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 1000)
    {
        throw new ArgumentException("Invalid input.");
    }

    var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    if (nums.Count != n)
    {
        throw new ArgumentException("Invalid input.");
    }

    var positiveNums = nums.Where(x => x > 0).ToList();
    var negativeNums = nums.Where(x => x < 0).ToList();
    var zeroNums = nums.Where(x => x == 0).ToList();

    Console.WriteLine($"Positives: {string.Join(" ", positiveNums)}");
    Console.WriteLine($"Negatives: {string.Join(" ", negativeNums)}");
    Console.WriteLine($"Zeros: {string.Join(" ", zeroNums)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}