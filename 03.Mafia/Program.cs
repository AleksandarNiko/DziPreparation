
int[]lineToken = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int jewelleryPrice = lineToken[0];
int goldPrice = lineToken[1];

int jewSum = 0;
int goldSum = 0;
int expenses = 0;

string input;
while((input = Console.ReadLine()) != "Jail Time")
{
    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string loot = tokens[0];
    int heistExpenses = int.Parse(tokens[1]);

    foreach (var l in loot)
    {
        if (l == '%')
        {
            jewSum+=jewelleryPrice;
        }
        else if (l == '$')
        {
            goldSum+=goldPrice;
        }
        else
        {
            continue;
        }
    }

    expenses+= heistExpenses;
}

var totalSum = jewSum + goldSum;

if(totalSum>=expenses)
{
    Console.WriteLine($"Heists will continue. Total earnings: {totalSum - expenses}.");
}
else
{
    Console.WriteLine($"Have to find another job. Lost: {expenses - totalSum}.");
}

/*
2000 10000
ASDAs 500000
%ASD$ 1000000
$S$&*_ASD 1000
AF#^&*LP 20000
$ 100000000
Jail Time
*/