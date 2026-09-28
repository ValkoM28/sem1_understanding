namespace RPGCombat;

public class Mage : Character
{
    private Random random = new();

    public Mage(string name, int health, int attackPower) : base(name, health, attackPower)
    {

    }
    public override int Attack()
    {
        return AttackPower + random.Next(-5, 6);
    }
}