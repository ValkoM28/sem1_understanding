namespace SpaceMissionControlSystem;

class Program
{
    public static List<Mission> missions = [];
    public static void Main()
    {
        /*Console.WriteLine("Space Mission Control");
        Console.WriteLine("1. View Spacecraft Status");
        Console.WriteLine("2. Assign Mission");
        Console.WriteLine("3. Check Sector Status");
        Console.WriteLine("4. Launch sequence");
        Console.WriteLine("5. Exit Program");*/

        //string content = "New STring";

        /*Console.WriteLine($@"Space Mission Control
        1. View Spacecraft Status {content}
        2. Assign Mission
        3. Check Sector Status
        4. Launch sequence
        5. Exit Program
        ");*/
        
         /*Console.WriteLine("""
        Space Mission Control
        1. View Spacecraft Status {content}
        2. Assign Mission
        3. Check Sector Status
        4. Launch sequence
        5. Exit Program 
        """);*/

        bool exit = false;
        while(!exit)
        {
            Console.WriteLine("""
                Space Mission Control
                1. Add Mission
                2. View Mission
                3. Launch Mission
                4. Abort Mission
                5. Search Mission
                5. Exit Program 
            """);
            string? choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    AddMission();
                    break;
                case "2":
                    ViewMission();
                    break;
                case "3":
                    LaunchMission();
                    break;        
                case "4":
                    AbortMission();
                    break;
                case "5":
                    SearchMission();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Please enter 1-5");
                    break;
            }
        }
        
        static void AddMission()
        {
            Console.WriteLine("Enter Mission Name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter Destination: ");
            string? destination = Console.ReadLine();
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(destination))
            {
                Console.WriteLine("Name and destination are required.");
            }
            var mission = new Mission(name, destination);
            missions.Add(mission);
        }

        static void ViewMission()
        {
            if(missions.Count == 0)
            {
                Console.WriteLine("No mission avalable!");
                return;
            }
            Console.WriteLine("Current Missions: ");
            foreach(var mission in missions)
            {
                Console.WriteLine($"Name: {mission.Name}, Destination {mission.Destination}, Status {mission.Status}");
                Console.WriteLine();
            }
        }

        static void LaunchMission()
        {
            Console.WriteLine("ENter mission name to launch: ");
            string? name = Console.ReadLine();
            Mission? missionToLaunch = null;
            foreach(var mission in missions)
            {
                if(mission.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    missionToLaunch = mission;
                    break;
                }
            }
            if(missionToLaunch != null && missionToLaunch.Status == "Schedule")
            {
                missionToLaunch.Launch();
            }
            else
            {
                Console.WriteLine("Mission nt found or cannot be launched");
            }
        }

        static void AbortMission()
        {

        }

        static void SearchMission()
        {

        }
       
    }
}
