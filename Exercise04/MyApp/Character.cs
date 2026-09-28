namespace RPGCombat;
public class Character
{
    public string Name {get;}
    protected int Health {get; private set;}
    protected int AttackPower {get;}
    public Character(string name, int healt, int attackPower)
    {
        Name = name;
        Health = healt;
        AttackPower = attackPower;
    }    

    public virtual int Attack() => AttackPower;
    public void TakeDamage(int damage)
    {
        Health = Math.Max(0, Health - damage);
    }

    public bool IsAlive => Health > 0;
    public override string ToString() => $"{Name} - Health: {Health}";
}