
using _03.zad28Year2023;

string rallyName = Console.ReadLine();
int year = int.Parse(Console.ReadLine());

Rally rally = new Rally(rallyName, year);

Console.WriteLine("[a]dd [v]iew [q]uit");

string command = Console.ReadLine();

switch (command)
{
	case "a":
		string pilotName = Console.ReadLine();
		int pilotAge = int.Parse(Console.ReadLine());
        string pilotCategory = Console.ReadLine();
        string carBrand =  Console.ReadLine();
		int carHPower = int.Parse(Console.ReadLine());
		Car car = new Car(carBrand, carHPower);
		Pilot pilot = new Pilot(pilotName, pilotAge, car, pilotCategory);
		rally.AddPilot(pilot);
		break;

		case "v":
		Console.WriteLine(rally.ToString());
        break;
			case "q":
		return;
    default:
		break;
}
