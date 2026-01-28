
using _02.zad26Year2022;
using System.Net.Http.Headers;
using System.Threading.Tasks.Sources;

int peopleCount = int.Parse(Console.ReadLine());

Stack<Human> people = new Stack<Human>();

for (int i = 0; i < peopleCount; i++)
{
    var firstNameToken = Console.ReadLine().Split(" ");
    var lastNameToken = Console.ReadLine().Split(" ");
    var ageToken = Console.ReadLine().Split(" ");

    string firstName = firstNameToken[2];
    var lastName = lastNameToken[2];
    int age = int.Parse(ageToken[1]);

    var choiceToken = Console.ReadLine().Split(" ");
    var choice = choiceToken[8];

    if(choice == "s")
    {
        var gradeToken = Console.ReadLine().Split(" ");
        double grade = double.Parse(gradeToken[1]);

        Student student = new Student(firstName, lastName, age, grade);
        people.Push(student);
    }
    else if(choice == "w")
    {
        var wageToken = Console.ReadLine().Split(" ");
        var workHoursToken = Console.ReadLine().Split(" ");
        double wage = double.Parse(wageToken[1]);
        int workHours = int.Parse(workHoursToken[2]);
        Worker worker = new Worker(firstName, lastName, age, wage, workHours);
        people.Push(worker);
    }
}

Console.WriteLine();

foreach (var person in people)
{
    Console.WriteLine(person.ToString());
}
