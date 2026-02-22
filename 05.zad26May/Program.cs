

using _05.zad26May;

try
{
    var n = int.Parse(Console.ReadLine()!);

    var itemList = new ItemList();

    for (int i = 0; i < n; i++)
    {
        var input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var description = input[0];
        var price = decimal.Parse(input[1]);
        var item = new Item(description, price);
        itemList.AddItem(item);
    }

    Console.WriteLine($"Elements count: {itemList.Size}");

    int index =int.Parse(Console.ReadLine()!);

    Console.WriteLine(itemList.Get(index));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
