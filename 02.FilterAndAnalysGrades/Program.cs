
try
{
    int n;

    if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 1000)
    {
        throw new ArgumentException("Invalid input.");
    }

    var grades = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    if (grades.Count != n)
    {
        throw new ArgumentException("Invalid input.");
    }

    var perfectGrades = grades.Where(g => g == 6).ToList();
    Console.WriteLine(perfectGrades.Count);

    var avgGrade = grades.Average();
    Console.WriteLine(avgGrade);

    var gradesAboveAvg = grades.Where(g => g > avgGrade).ToList();
    Console.WriteLine(gradesAboveAvg);

}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
