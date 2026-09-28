namespace SpaceMissionControlSystem;

public class Mission
{
    public string Name {get; }
    public string Destination {get; }
    public string Status {get; private set;}
    public Mission(string name, string destination)
    {
        Name = name;
        Destination = destination;
        Status = "Schedule";
    }
    public void Launch()
    {
        Status = "Launched";
        Console.WriteLine($"Mission {Name} is in {Destination} has been {Status}");
    }
     public void Abort()
    {
        Status = "Aborted";
        Console.WriteLine($"Mission {Name} is in {Destination} has been {Status}");
    }
}