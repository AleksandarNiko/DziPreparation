using System;
using System.Linq;
using System.Globalization;

int n = int.Parse(Console.ReadLine() ?? "0");
double[] earnings = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

if (earnings.Length == 0)
{
    Console.WriteLine("The longest period with bigger profit is 0 mounths.");
    Console.WriteLine("Smaller with 0.00 %.");
    return;
}

int longest = 1;
int current = 1;
for (int i = 1; i < earnings.Length; i++)
{
    if (earnings[i] >= earnings[i - 1])
    {
        current++;
    }
    else
    {
        current = 1;
    }

    if (current > longest)
    {
        longest = current;
    }
}

double minVal = earnings.Min();
int minIndex = Array.IndexOf(earnings, minVal);
double compareWith;
if (earnings.Length == 1)
{
    compareWith = minVal;
}
else if (minIndex == earnings.Length - 1)
{
    compareWith = earnings[earnings.Length - 2];
}
else
{
    compareWith = earnings[minIndex + 1];
}

double percent = 0.0;
if (compareWith != 0)
{
    percent = ((compareWith - minVal) / compareWith) * 100.0;
}

Console.WriteLine($"The longest period with bigger profit is {longest} mounths.");
Console.WriteLine($"Smaller with {percent.ToString("F2", CultureInfo.InvariantCulture)} %.");



