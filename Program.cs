Warrior warrior = new Warrior("Conan", 100);
Wizard wizard = new Wizard("Gandalf", 75);

Console.WriteLine($"Name: {warrior.Name}");
Console.WriteLine($"Health: {warrior.Health}");
warrior.Attack();

Console.WriteLine();

Console.WriteLine($"Name: {wizard.Name}");
Console.WriteLine($"Health: {wizard.Health}");
wizard.Attack();