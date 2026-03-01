
using zad28Year2025August;

try
{
    string path = "input.txt";

    var employees = new List<HospitalStaff>();

    using (var reader = new StreamReader(path))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split(',');

            if (parts.Length < 6 || parts.Length > 7)
            {
                throw new Exception($"Invalid line format: {line}");
            }

            string role = parts[0].Trim();

            if (role == "Doctor")
            {
                string firstName = parts[1].Trim();
                string lastName = parts[2].Trim();
                int age = int.Parse(parts[3].Trim());
                decimal salary = decimal.Parse(parts[4].Trim());
                string specialization = parts[5].Trim();
                int patientsTreated = int.Parse(parts[6].Trim());
                var doctor = new Doctor(firstName, lastName, age, salary, specialization, patientsTreated);
                employees.Add(doctor);

            }
            else if (role == "Nurse")
            {
                string firstName = parts[1].Trim();
                string lastName = parts[2].Trim();
                int age = int.Parse(parts[3].Trim());
                decimal salary = decimal.Parse(parts[4].Trim());
                string department = parts[5].Trim();
                int shiftsWorked = int.Parse(parts[6].Trim());
                var nurse = new Nurse(firstName, lastName, age, salary, department, shiftsWorked);
                employees.Add(nurse);
            }
            else if (role == "Janitor")
            {
                string firstName = parts[1].Trim();
                string lastName = parts[2].Trim();
                int age = int.Parse(parts[3].Trim());
                decimal salary = decimal.Parse(parts[4].Trim());
                int areaCovered = int.Parse(parts[5].Trim());
                var janitor = new Janitor(firstName, lastName, age, salary, areaCovered);
                employees.Add(janitor);
            }
        }
    }

    Console.WriteLine("Employees sorted by age:");
    employees.Sort((e1, e2) => e1.Age.CompareTo(e2.Age));
    foreach (var employee in employees)
    {
        employee.Info();
    }

    Console.WriteLine("Employee with the highest salary:");
    var highestSalaryEmployee = employees
        .OrderByDescending(e => e.Salary)
        .FirstOrDefault();

    highestSalaryEmployee.Info();

    Console.WriteLine();

    Console.WriteLine("Doctor with most patients treated:");
    var doctorWithMostPatients = employees
        .OfType<Doctor>()
        .OrderByDescending(d => d.PatientsTreated)
        .FirstOrDefault();

    doctorWithMostPatients.Info();

    Console.WriteLine();

    Console.WriteLine("Most hardworking employee (Nurse or Janitor):");

    var mostHardworkingEmployee = employees
        .Where(e => e is Nurse || e is Janitor)
        .OrderByDescending(e =>
        {
            if (e is Nurse nurse)
            {
                return nurse.ShiftsWorked;
            }
            else if (e is Janitor janitor)
            {
                return janitor.AreaCovered;
            }
            return 0;
        })
        .FirstOrDefault();
    mostHardworkingEmployee.Info();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

