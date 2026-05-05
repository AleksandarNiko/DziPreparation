
var wordsList = new List<string>();

string command = "";
while((command = Console.ReadLine()) != "END")
{
    switch(command)
    {
        case "Add":
            var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            wordsList.AddRange(words);
            break;
        case "Remove":
            var indexToRemove = int.Parse(Console.ReadLine());
            if (indexToRemove >= 0 && indexToRemove < wordsList.Count)
            {
                wordsList.RemoveAt(indexToRemove);
            }
            break;
        case "Search":
            var word = Console.ReadLine();
            if (wordsList.Contains(word))
            {
                Console.WriteLine(word);
            }
            else
            {
                Console.WriteLine("Not contained.");
            }
            break;
        case "Update":
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (!string.IsNullOrEmpty(wordsList[i]) && char.IsLetter(wordsList[i][0]))
                {
                    wordsList[i] = char.ToUpper(wordsList[i][0]) + wordsList[i].Substring(1);
                }
            }
            break;
        case "Length":
            var length = int.Parse(Console.ReadLine());
            var wordsOfLength = wordsList.Where(w => w.Length == length);
            if(wordsOfLength.Any())
            {
                Console.WriteLine(string.Join("-", wordsOfLength));
            }
            else
            {
                Console.WriteLine("Not contained.");
            }
            break;
        case "Insert":
            int indexToInsert = int.Parse(Console.ReadLine());
            var currWord = Console.ReadLine();
            if (indexToInsert >= 0 && indexToInsert <= wordsList.Count)
            {
                wordsList.Insert(indexToInsert, currWord);
            }
            else
            {
                Console.WriteLine("There are not enough items in the list.");
            }
            break;
        case "Print":
            Console.WriteLine(string.Join("; ", wordsList));
            break;
    }
}

/*
Add
matematika informatika IT fizika izpit
Remove
2
Add
BEL papka
Update
Print
Insert
4
Istoria
Length
5
Search
IT
Insert
9
Matura
Insert
3
DZI
Print
END
*/
