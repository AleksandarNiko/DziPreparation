

try
{
    var commands = new List<string>()
{"Add", "Remove", "Search", "Update", "Length", "Insert", "Print","END" };

    var words = new List<string>();


    string input = "";

    while ((input = Console.ReadLine()) != "END")
    {
        var lineToken = input
            .Split(" ")
            .ToList();

        string command = lineToken[0];

        if (!commands.Contains(command))
        {
            throw new Exception($"Invalid command {nameof(command)}");
        }

        if (command == "Add")
        {
            var currWords = lineToken[1]
                .Split(" ")
                .ToList();

            words.AddRange(currWords);

            Console.WriteLine(string.Join(" ", words));
        }
        else if (command == "Remove")
        {
            int index = int.Parse(lineToken[1]);

            words.RemoveAt(index);

            Console.WriteLine(string.Join(" ", words));
        }
        else if (command == "Search")
        {
            string wordToSearch = lineToken[1];

            if (words.Contains(wordToSearch))
            {
                Console.WriteLine(wordToSearch);
            }
            else
            {
                Console.WriteLine("Not contained.");
            }
        }
        else if (command == "Update")
        {
            foreach (var word in words)
            {
                var firstChar = word[0];

                if (char.IsLetter(firstChar))
                {
                    char.ToUpper(firstChar);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }
        else if (command == "Length")
        {
            int n = int.Parse(lineToken[1]);

            var currWords = words.Where(w => w.Length == n);

            if (currWords.Any())
            {
                Console.WriteLine(string.Join("-", currWords));
            }
            else
            {
                Console.WriteLine("Not contained.");
            }
        }
        else if (command == "Insert")
        {
            int n = int.Parse(lineToken[1]);
            string wordToInsert = lineToken[2];

            if (n < 0 || n > words.Count)
            {
                Console.WriteLine("There are not enough items in the list.");
            }
            else
            {
                words.Insert(n, wordToInsert);
                Console.WriteLine(string.Join(" ", words));
            }
        }
        else if (command == "Print")
        {
            if (words.Any())
            {
                Console.WriteLine(string.Join("; ",words));
            }
            else
            {
                Console.WriteLine("Nothing found.");
            }
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
