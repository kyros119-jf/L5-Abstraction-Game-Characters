public class Warrior : GameCharacter
{
    public Warrior(string name, int health) : base(name, health)
    {
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with a sword!");
    }
}