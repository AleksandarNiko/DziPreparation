
using zad28Year2024;

string path = "input.txt";

var clubMembers = new List<ClubMember>();

using (StreamReader reader = new StreamReader(path))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] parts = line.Split(";");

        if (line.Length == 9)
        {
            try
            {
                string firstName = parts[0];
                string lastName = parts[1];
                int age = int.Parse(parts[2]);
                decimal salary = decimal.Parse(parts[3]);
                string position = parts[4];
                int contractLength = int.Parse(parts[5]);
                int matches = int.Parse(parts[6]);
                int goals = int.Parse(parts[7]);
                int assist = int.Parse(parts[8]);
                var player = new FootballPlayer(firstName, lastName, age, salary, position,contractLength,matches, goals,assist);
                clubMembers.Add(player);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else if (line.Length == 6)
        {
            try
            {
                string firstName = parts[0];
                string lastName = parts[1];
                int age = int.Parse(parts[2]);
                decimal salary = decimal.Parse(parts[3]);
                string coachType = parts[4];
                int contractLength = int.Parse(parts[5]);
                var coach = new Coach( firstName,  lastName,  age,  salary,  coachType,  contractLength);
                clubMembers.Add(coach);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else if (line.Length == 5)
        {
            try
            {
                string firstName = parts[0];
                string lastName = parts[1];
                int age = int.Parse(parts[2]);
                decimal salary = decimal.Parse(parts[3]);
                string directorType = parts[4];
                var player = new Director( firstName,  lastName,  age,  salary,  directorType);
                clubMembers.Add(player);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

var orderedMembers = clubMembers
    .OrderBy(cm => cm.Age);

foreach (var member in clubMembers.OrderBy(cm => cm.Age))
{
    member.Info();
    Console.WriteLine("********************");
}

//var highestSalaryPlayer = clubMembers
//    .OrderBy(cm => cm.Salary)
//    .LastOrDefault();

//Console.WriteLine($"The person with the highest salary in the club is {highestSalaryPlayer.FirstName} {highestSalaryPlayer.LastName} with {highestSalaryPlayer.Salary:f2} lv salary.");

//var topScorer = clubMembers
//    .Where(cm => cm is FootballPlayer)
//    .Cast<FootballPlayer>()
//    .OrderByDescending(fp => fp.Goals)
//    .FirstOrDefault();

//Console.WriteLine($"The team's top scorer is {topScorer.FirstName} {topScorer.LastName} with {topScorer.Goals} goals.");