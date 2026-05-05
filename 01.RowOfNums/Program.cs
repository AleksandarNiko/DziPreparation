
var nums = Console.ReadLine()!
    .Split()
    .Select(int.Parse)
    .ToList();

string command;

while((command = Console.ReadLine()!) != "end")
{
    var cmdArgs = command.Split();
    var cmdType = cmdArgs[0].ToLower();

    switch (cmdType)
    {
        case "add":
            int x = int.Parse(cmdArgs[1]);
            nums.Add(x);
            break;

            case "remove":
            int x1 = int.Parse(cmdArgs[1]);
            var indexOf = nums.IndexOf(x1);
            if(indexOf > -1)
            {
                nums.RemoveAt(indexOf);
            }
            break;

            case "multiply":
            int x2 = int.Parse(cmdArgs[1]);
            int y = int.Parse(cmdArgs[2]);

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == x2)
                {
                    nums[i] *= y;
                }
            }
            break;

        case "sum":
            Console.WriteLine($"Sum: {nums.Sum()}");
            break;
        case "max":
            if (nums.Any())
            {
                Console.WriteLine($"Max: {nums.Max()}");
            }
            else
            {
                Console.WriteLine("Max: List is empty.");
            }
            break;
            case "filter":
            int x3 = int.Parse(cmdArgs[1]);
            nums.RemoveAll(n => n < x3);
            break;
        case "squarecheck":
            int x4 = int.Parse(cmdArgs[1]);
            if (x4 >= 0 && Math.Sqrt(x4) == (int)Math.Sqrt(x4))
            {
                nums.Add(x4);
                Console.WriteLine($"{x4} is a perfect square and has been added to the list.");
            }
            else
            {
                Console.WriteLine($"{x4} is not a perfect square.");
            }
            break;
            default: 
            Console.WriteLine("Invalid command."); 
            break;
    }
}
Console.WriteLine($"Final list: [{string.Join(", ", nums)}]");

/*
10 20 30 40 50
Add 60
Sum
Max
SquareCheck -25
Multiply 10 2
Filter 30
SquareCheck 169
Remove 40
end
*/