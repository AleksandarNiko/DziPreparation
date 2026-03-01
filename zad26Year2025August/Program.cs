
try
{
    int n = int.Parse(Console.ReadLine()!);

    if(n<1 || n> 1000000)
    {
        throw new Exception("N must be between 1 and 100.");
    }

    var values = new long[n];

    for (int i = 0; i < n; i++)
    {
        long a = long.Parse(Console.ReadLine()!);

        if(a < 0 || a > 1000000)
        {
            throw new Exception("A must be between 0 and 1,000,000.");
        }

        values[i] = a;
    }

    double maxA = values.Max() + 1;
    Console.WriteLine($"Max Element = {maxA}");

    string s = maxA.ToString();
    var digits = s.ToCharArray();
    Array.Sort(digits);
    Array.Reverse(digits);
    string maxDigitStr = new string(digits);
    var maxDigit = double.Parse(maxDigitStr);

    Console.WriteLine($"Max Digit = {maxDigit}");

    Console.WriteLine($"next Max Digit = {maxDigit+1}");

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
