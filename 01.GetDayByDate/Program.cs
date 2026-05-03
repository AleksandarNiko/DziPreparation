
int[] dayMonth=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int day = dayMonth[0];
int month = dayMonth[1];

DateTime date = new DateTime(2026, month, day);

Console.WriteLine(date.DayOfWeek);