namespace RPGCombat;
/*Requirements
create a single rpg combat system
character have basic stats
different character types
basic combat where character can attack each other
basic status display
system should demostrate coupling, access control, ans srp*/

public class Program
{
    public static void Main()
    {
        Warrior warrior = new("Manish", health: 120, attackPower: 15);
        Mage mage = new("Mats", health: 80, attackPower: 30);
        Console.WriteLine("Battle Begins");
        Console.WriteLine("Initial Status");
        Console.WriteLine(warrior);
        Console.WriteLine(mage);
        Console.WriteLine();
        while(warrior.IsAlive && mage.IsAlive)
        {
            var warriorAttack = new Combat(warrior, mage);
            warriorAttack.ExecuteAttack();
            if(!mage.IsAlive)
            {
                Console.WriteLine();
                Console.WriteLine($"{warrior.Name} wins!");
                break;
            }
            Console.WriteLine();
            var mageAttack= new Combat(mage, warrior);
            mageAttack.ExecuteAttack();
            if(!warrior.IsAlive)
            {
                Console.WriteLine();
                Console.WriteLine($"{mage.Name} wins!");
                break;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key for next round...");
            Console.ReadKey();
        }
    }
}