public abstract class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
        
    }   
    
    public abstract void Attack();
}