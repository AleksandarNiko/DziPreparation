
using System;
using System.Linq;

int[] firstDayMonth = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int day1 = firstDayMonth[0];
int month1 = firstDayMonth[1];
DateTime startDate = new DateTime(2026, month1, day1);

string dayOfWeek = Console.ReadLine()!;

int[] secondDayMonth = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int day2 = secondDayMonth[0];
int month2 = secondDayMonth[1];
DateTime endDate = new DateTime(2026, month2, day2);

int mondaysCount = 0;
int saturdaysCount = 0;
int sundaysCount = 0;

for(DateTime i = startDate.Date ; i <= endDate.Date; i = i.AddDays(1))
{
    if(i.DayOfWeek == DayOfWeek.Monday)
    {
        mondaysCount++;
    }
    else if(i.DayOfWeek == DayOfWeek.Saturday)
    {
        saturdaysCount++;
    }
    else if(i.DayOfWeek == DayOfWeek.Sunday)
    {
        sundaysCount++;
    }
}

Console.WriteLine($"{mondaysCount} {saturdaysCount} {sundaysCount}");

/*
1 1
Thursday
31 1
*/