namespace RPGCombat;

 public class Combat
 {
    private Character attacker;
    private Character defender;
    public Combat(Character attacker, Character defender)
    {
        this.attacker = attacker;
        this.defender = defender;
    }
    public void ExecuteAttack()
    {
        int damage = attacker.Attack();
        defender.TakeDamage(damage);
        Console.WriteLine($"{attacker.Name} attacks {defender.Name} for{damage} damage!");
        Console.WriteLine(defender.ToString());
    }
 }