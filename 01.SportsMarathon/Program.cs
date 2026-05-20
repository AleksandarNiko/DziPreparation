
using _01.SportsMarathon;

int playersCount = int.Parse(Console.ReadLine());

var participants = new List<Participant>();

for (int i = 0; i < playersCount; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Participant participant = new Participant
    {
        Name = input[0],
        Country = input[1],
        AgeGroup = input[2],
        Time = int.Parse(input[3])
    };
    participants.Add(participant);
}

string ageGroupToCheck = Console.ReadLine();
int maxTime = int.Parse(Console.ReadLine());

var filteredParticipants = participants
    .Where(p => p.AgeGroup == ageGroupToCheck && p.Time <= maxTime)
    .OrderBy(p => p.Time)
    .ToList();

if (filteredParticipants.Any())
{
    foreach (var participant in filteredParticipants)
    {
        Console.WriteLine($"{participant.Name} {participant.Country} - {participant.Time} сек.");
    }

    Console.WriteLine("Средно време: {0:F2} сек.", filteredParticipants.Average(p => p.Time));

}
else
{
    Console.WriteLine("No participants found.");
}

/*
4
Иван BUL Мъже 3600
Джон USA Мъже 3450
Пиер FRA Ветерани 4200
Алекс BUL Мъже 3800
Мъже
3700
*/