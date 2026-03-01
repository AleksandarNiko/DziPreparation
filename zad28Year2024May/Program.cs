
using zad28Year2024May;

string path = "data.txt";

var kinderGarden = new KinderGarden();

using (StreamReader reader = new StreamReader(path))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] parts = line.Split(" ");
        string command = parts[0];

        if (command == "enrollment")
        {
            try
            {
                string firstName = parts[1];
                string lastName = parts[2];
                string id = parts[3];
                int age = int.Parse(parts[4]);
                string parentLastName = parts[5];
                string parentGSM = parts[6];

                if (kinderGarden.isKidIdContained(id))
                {
                    Console.WriteLine($"Enrollment failed - the child with identifier {id} already exists.");
                    continue;
                }
                else
                {
                    var kid = new Kid(id, firstName, lastName, age, parentLastName, parentGSM);

                    kinderGarden.EnrollKid(kid);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        else if (command == "unsubscribe")
        {
            string id = parts[1];
            kinderGarden.ReleaseKid(id);

        }
        else if (command == "information")
        {
            string group = parts[1];
            kinderGarden.GroupInfo(group);
        }
        else if (command == "END")
        {
            Console.WriteLine("Have a nice day!");
            break;
        }
        else
        {
            Console.WriteLine($"{command} - invalid command.");
        }
    }
}