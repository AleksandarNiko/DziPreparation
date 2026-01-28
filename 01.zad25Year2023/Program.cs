

double n = double.Parse(Console.ReadLine()!);

try
{
    if (n < 1 || n > 10000000 || double.IsRealNumber(n)!=true)
    {
        throw new ArgumentOutOfRangeException("Incorrectly entered number");
    }

    string strN = n.ToString();

    if (strN == new string(strN.Reverse().ToArray()))
    {
        Console.WriteLine($"{n} is a palindrome.");
    }
    else
    {
        Console.WriteLine($"{n} is NOT a palindrome.");
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    return;
}