namespace RPGCombat;

public class Warrior:Character
{
    private Random random = new();
    public Warrior(string name, int health, int attackPower) : base(name, health, attackPower)
    {}
    public override int Attack()
    {
        if(random.Next(1, 101)<=20) // critical hit
        {
            return AttackPower *2;
        }
        else
        {
            return AttackPower;
        }
    }
}