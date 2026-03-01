

var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());

var digitCountDic = new Dictionary<int, int>();

for (int i = a; i <= b; i++)
{
    int currNum = i;

    while (currNum != 0)
    {
        int digit = currNum % 10;
        if (digitCountDic.ContainsKey(digit))
        {
            digitCountDic[digit]++;
        }
        else
        {
            digitCountDic.Add(digit, 1);
        }
        currNum/= 10;
    }
}

var minKey = digitCountDic
    .OrderByDescending(x => x.Value)
    .ThenBy(x => x.Key)
    .FirstOrDefault();

Console.WriteLine($"Digit {minKey.Key} - {minKey.Value} times");





