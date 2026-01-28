int a, b;
if (!int.TryParse(Console.ReadLine(), out a) || !int.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Некоректно въведено число");
    return;
}
if (a == 0)
{
    if (b > 0)
    {
        Console.WriteLine("Всички реални числа са решения");
    }
    else
    {
        Console.WriteLine("Няма реални решения");
    }
}
else
{
    double x = (double)b / a;
    if (a > 0)
    {
        if (x <= 0)
        {
            Console.WriteLine("Няма реални решения");
        }
        else
        {
            double root = Math.Sqrt(x);
            Console.WriteLine($"Решенията са ({-root:F2}; {root:F2})");
        }
    }
    else
    {
        if (x < 0)
        {
            Console.WriteLine("Всички реални числа са решения");
        }
        else
        {
            double root = Math.Sqrt(x);
            Console.WriteLine($"Решенията са (-inf; {-root:F2}) U ({root:F2}; +inf)");
        }
    }
}