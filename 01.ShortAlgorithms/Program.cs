

zadacha5();
zadacha6();
zadacha7();
zadacha8();


static void zadacha6()
{
    string? input = Console.ReadLine();
    if (input is null)
    {
        return;
    }

    var stack = new Stack<char>();
    bool balanced = true;

    foreach (char c in input)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (stack.Count == 0)
            {
                balanced = false;
                break;
            }

            char top = stack.Pop();
            if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
            {
                balanced = false;
                break;
            }
        }
    }

    if (stack.Count != 0) balanced = false;

    Console.WriteLine(balanced ? "YES" : "NO");
}

static void zadacha5()
{
    var nums = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    Dictionary<int, int> counts = new();

    foreach (var num in nums)
    {
        if (counts.ContainsKey(num))
        {
            counts[num]++;
        }
        else
        {
            counts.Add(num, 1);
        }
    }

    foreach (var item in counts)
    {
        if (item.Value > 1)
        {
            counts.Remove(item.Key);
        }
    }

    var result = counts.OrderByDescending(x => x.Key);

    foreach (var item in result)
    {
        Console.Write(item.Key + " ");
    }
}

static void zadacha7()
{
    var input = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    var dic = new SortedDictionary<string, int>();

    foreach (var item in input)
    {
        if (dic.ContainsKey(item))
        {
            dic[item]++;
        }
        else
        {
            dic.Add(item, 1);
        }
    }

    foreach (var item in dic)
    {
        Console.WriteLine($"{item.Key} -> {item.Value}");
    }
}

static void zadacha8()
{
    var queue = new Queue<string>();
    string input = "";

    while ((input = Console.ReadLine()!) != "End")
    {
        if (input == "Paid")
        {
            Console.WriteLine(queue.Dequeue());
        }
        else
        {
            queue.Enqueue(input);
        }
    }

    Console.WriteLine(queue.Count);
}