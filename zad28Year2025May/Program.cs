
using zad28Year2025May;

try
{
    string path = "input.txt";

    var members = new List<SchoolMember>();

    using (var reader = new StreamReader(path))
    {
        string line;
        int lineNumber = 0;
        while ((line = reader.ReadLine()) != null)
        {
            lineNumber++;

            try
            {
                var parts = line.Split(";");
                if (parts.Length == 0)
                { throw new ArgumentException("Empty line"); }

                string role = parts[0];

                switch (role)
                {
                    case "Student":
                        if (parts.Length < 5)
                        {
                            throw new ArgumentException("Not enough fields for Student");
                        }
                        string name = parts[1];
                        int age = int.Parse(parts[2]);
                        string instrument = parts[3];
                        int practiceHours = int.Parse(parts[4]);

                        members.Add(new Student(name, age, instrument, practiceHours));
                        break;

                    case "Teacher":
                        if (parts.Length < 6)
                        {
                            throw new ArgumentException("Not enough fields for Teacher");
                        }
                        string nameT = parts[1];
                        int ageT = int.Parse(parts[2]);
                        string specialty = parts[3];
                        int studentsCount = int.Parse(parts[4]);
                        double salary = double.Parse(parts[5]);

                        double bonusPerStudent = 0.02 * salary;
                        double bonus = bonusPerStudent * studentsCount;

                        members.Add(new Teacher(nameT, ageT, specialty, studentsCount, salary, bonus));
                        break;

                    case "Manager":
                        if (parts.Length < 5)
                        {
                            throw new ArgumentException("Not enough fields for Manager");
                        }
                        string nameM = parts[1];
                        int ageM = int.Parse(parts[2]);
                        double budget = double.Parse(parts[3]);
                        int YearsInService = int.Parse(parts[4]);

                        members.Add(new Manager(nameM, ageM, budget, YearsInService));
                        break;
                    default:
                        Console.WriteLine($"Unknown role: {role}");
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Invalid data on line {lineNumber}: {e.Message}");
            }
        }
    }

    var orderedMembers = members
        .OrderBy(m => m.Age)
        .ToList();

    foreach (var member in orderedMembers)
    {
        member.Info();
        Console.WriteLine("----------");
    }

    var teachers = members
        .OfType<Teacher>()
        .ToList();

    if (teachers.Any())
    {
        var teacherWithMostStudents = teachers
            .OrderByDescending(t => t.StudentsCount)
            .FirstOrDefault();

    Console.WriteLine($"The teacher with the most students is {teacherWithMostStudents.Name} with {teacherWithMostStudents.StudentsCount} students.");
    }
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
