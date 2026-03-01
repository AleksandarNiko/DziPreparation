
using System.Linq.Expressions;

int n = int.Parse(Console.ReadLine()!);

var personalDigitsDic = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    string[] dates = Console.ReadLine()!.Split('-');
    var days = int.Parse(dates[0]);
    var months = int.Parse(dates[1]);
    var years = int.Parse(dates[2]);

    int daysSum = 0;
    int monthsSum = 0;
    int yearsSum = 0;

    while (days > 0)
    {
        daysSum += days % 10;
        days /= 10;
    }

    while (months > 0) { 
        monthsSum += months % 10;
        months /= 10;
    }

    while (years > 0)
    {
        yearsSum += years % 10;
        years /= 10;
    }

    int specialNumber = daysSum + monthsSum + yearsSum;

    while (specialNumber > 9 && specialNumber != 11 && specialNumber != 22)
    {
        int temp = 0;
        while (specialNumber > 0)
        {
            temp += specialNumber % 10;
            specialNumber /= 10;
        }
        specialNumber = temp;
    }

    if (!personalDigitsDic.ContainsKey(specialNumber)) 
    {
        personalDigitsDic.Add(specialNumber,1);
    }
    else
    {
        personalDigitsDic[specialNumber]++;
    }
}

var mostCommonPersonalNumber = personalDigitsDic
    .OrderByDescending(n=>n.Value)
    .ThenBy(n=>n.Key)
    .FirstOrDefault();

Console.WriteLine($"The most common personal number is {mostCommonPersonalNumber.Key} - {mostCommonPersonalNumber.Value} times");

string quality = "";

switch (mostCommonPersonalNumber.Key)
{
    case 1:
        quality = "Independence";
        break;
    case 2:
        quality = "Diplomacy";
        break;
    case 3:
        quality = "Natural talent";
        break;
    case 4:
        quality = "Organizational skills";
        break;
    case 5:
        quality = "Free spirit";
        break;
    case 6:
        quality = "Caring and protection";
        break;
    case 7:
        quality = "Philosophical skills";
        break;
    case 8:
        quality = "Professionals";
        break;
    case 9:
        quality = "Tolerance and humanity";
        break;
    case 11:
        quality = "Visionaries with ideas";
        break;
    case 22:
        quality = "Confidence and intuition";
        break;
}

Console.WriteLine($"Characteristic quality: {quality}");