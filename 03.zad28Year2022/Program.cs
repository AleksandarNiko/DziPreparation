

using System.Collections.Concurrent;
using System.Threading.Channels;

bool Contains(string[,] matrix, string text)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int r = 0; r < rows; r++)
    {
        string rowString = "";
        for (int c = 0; c < cols; c++)
        {
            rowString += matrix[r, c];
        }
        if (rowString.Contains(text))
        {
            return true;
        }
    }

    for (int r = rows - 1; r >= 0; r--)
    {
        string rowString = "";
        for (int c = rows - 1; c >= 0; c--)
        {
            rowString += matrix[r, c];
        }
        if (rowString.Contains(text))
        {
            return true;
        }
    }
    return false;
}

string[,] ReadMatrix(string path)
{
    try
    {
        string[] lines = File.ReadAllLines(path);
        int rows = lines.Length;
        int cols = lines[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        string[,] matrix = new string[rows, cols];

        for (int r = 0; r < rows; r++)
        {
            string[] elements = lines[r].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int c = 0; c < cols; c++)
            {
                matrix[r, c] = elements[c];
            }
        }



        return matrix;
    }
    catch (Exception)
    {

        throw;
    }
   
}

List<string> ReadWords(string path)
{
    try
    {
        var words = new List<string>();
        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            words.Add(line.Trim());
        }

        return words;

    }
    catch (Exception)
    {
        throw;
    }
    
}

try
{
    Console.WriteLine("Name of the file with the table: ");
   
    string tableFileName = Console.ReadLine();
    string[,] table = ReadMatrix(tableFileName);
    if (table == null) 
    {
        return;
    }
    Console.WriteLine("Name of the file with the words: ");
   
    string wordsFileName = Console.ReadLine();
    List<string> words = ReadWords(wordsFileName);
    if (words == null) 
    {
        return;
    }

    foreach (string word in words)
    {
        if (Contains(table, word))
        {
            Console.WriteLine(word);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
