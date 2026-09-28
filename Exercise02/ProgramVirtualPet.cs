namespace VirtualPetGame;

public class Pet
{
    public long UniqueID { get; private set; }
    public decimal Money { get; set; }

    public float Age { get; set; }
    public float Health { get; set; }
    public float Happiness { get; set; }
    
    public string Name { get; set; }

    public Pet( string name, float age, float healt, float happiness)
    {
        Name = name;
        Age = age;
        Health = healt;
        Happiness = happiness;
    }

    public void Eat (float amount)
    {
        Console.WriteLine(Name + " ate " + amount + " food!");
    }

    public void Gamble (int duration)
    {
        Console.WriteLine(Name + " gambled for "+ duration + " minutes." );
    }

    public void Play (int duration)
    {
        Console.WriteLine( Name + " played for " + duration + " minutes.");
    }
}



public class VirtualPetManager 
{
    public static void Main()
    {
        Pet pet = new("Hakari", 2.0f, 100.0f, 10.0f);
        //pet.Name = "Hakari";
        pet.Eat(50);
        pet.Gamble(30);
        Console.WriteLine(pet.Name + " happiness level is "+ pet.Happiness);
    }
}