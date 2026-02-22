
using System.Net.WebSockets;

var nums = new List<int>();

static int SumDigits(int num)
{
    num = Math.Abs(num);
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

void Method1(List<int> nums, int k)
{

    for (int i = nums.Count - 1; i >= 0; i--)
    {
        if (SumDigits(nums[i]) % k == 0)
        {
            nums.RemoveAt(i);
        }
    }
}

 void Method2(List<int> nums)
{

    nums.Sort((a, b) => SumDigits(a).CompareTo(SumDigits(b)));
}

void Method3(string path)
{
    try
    {
        if(!File.Exists(path)) 
        {
            throw new Exception("File not found!");
        }
        if(Path.GetExtension(path) != ".txt") 
        {
            throw new Exception("Invalid file type!");
        }
        if(new FileInfo(path).Length == 0) 
        {
            throw new Exception("File is empty!");
        }

        using (var reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                int currNum = int.Parse(line);
                nums.Add(currNum);
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
     
string path = Console.ReadLine();
int k = int.Parse(Console.ReadLine());

Method3(path);

Method1(nums, k);

Method2(nums);

foreach (var num in nums) 
{
    Console.WriteLine(num);
}