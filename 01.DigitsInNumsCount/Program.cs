
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Dictionary<int, int> digCount = new Dictionary<int, int>();

for(int i  = a; i <= b; i++)
{
    int num = i;
    while (num > 0)
    {
        int dig = num % 10;
        if (digCount.ContainsKey(dig))
        {
            digCount[dig]++;
        }
        else
        {
            digCount[dig] = 1;
        }
        num /= 10;
    }
}

var sortedDigCount = digCount.OrderByDescending(kvp => kvp.Value);

foreach(var kvp in sortedDigCount)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}