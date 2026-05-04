

using System;
using System.Linq;

string[] info = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

if (info.Length < 4)
{
    Console.WriteLine("Invalid input");
    return;
}

int day = int.Parse(info[0]);
int month = int.Parse(info[1]);
string dayOfWeek = info[2];
string isLeapYear = info[3];

int[] dayMonth = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int day2 = dayMonth[0];
int month2 = dayMonth[1];

int[] monthLengths = new int[]
{
    31,
    isLeapYear == "yes" ? 29 : 28,
    31,
    30,
    31,
    30,
    31,
    31,
    30,
    31,
    30,
    31
};

int DayOfYear(int d, int m)
{
    if (m < 1 || m > 12) 
    {
        throw new ArgumentOutOfRangeException(nameof(m)); 
    }
    return d + monthLengths.Take(m - 1).Sum();
}

int doy1 = DayOfYear(day, month);
int doy2 = DayOfYear(day2, month2);
int delta = doy2 - doy1;

string[] names = new[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
int idx = Array.FindIndex(names, s => string.Equals(s, dayOfWeek, StringComparison.OrdinalIgnoreCase));
if (idx < 0)
{
    Console.WriteLine("Invalid day of week");
    return;
}

int newIdx = ((idx + delta) % 7 + 7) % 7;
Console.WriteLine(names[newIdx]);

/* Example
7 4 Wednesday no
25 12
*/
