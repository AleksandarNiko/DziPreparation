

try
{
    int n;
    var areValid = new List<bool>();

    if (!int.TryParse(Console.ReadLine(), out n)) 
    {
        throw new Exception("Something went wrong!");
    }

    var digits = new List<int>();

    var originalN = n;

    while (n != 0)
    {
        digits.Add(n % 10);
        n /= 10;
    }

    foreach (var digit in digits) 
    {
        if (originalN % digit == 0) 
        {
            areValid.Add(true);
        }
        else 
        {
            areValid.Add(false);
        }
    }

    if(areValid.All(x => x.Equals(true))) 
    {
        Console.WriteLine("Yes");
    }
    else 
    {
        Console.WriteLine("No");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



