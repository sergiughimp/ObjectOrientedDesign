using System;
using battleSimulation;

class Program
{
    // Battle method accepts any IAttackable
    public static void Battle(IAttackable attacker, IDefendable defender = null)
    {
        Console.WriteLine("=== Battle Begins ===");
        attacker.Attack();

        if (defender != null)
        {
            defender.Defend();
        }
        Console.WriteLine("=== Battle Ends ===\n");
    }

    static void Main(string[] args)
    {
        // Create characters
        Warrior warrior1 = new Warrior("Conan", 20, 15);
        Warrior warrior2 = new Warrior("Thor", 25, 10);
        IAttackable mage1 = new Mage("Merlin", 5);

        // Mage mage2 = new Mage("David", 7);


        // Individual battles
        Battle(warrior1, warrior2); // Warrior attacks Warrior
        Battle(mage1);               // Mage attacks only (from the interface IAttackable)
        // Battle(mage2);               // Mage attacks only (from the class Mage only)

        // // Mage performs healing (not called through interface)
        // Console.WriteLine("=== Healing Phase ===");
        // mage2.Healing();
        // Console.WriteLine();

        // All characters attack
        List<IAttackable> fighters = new List<IAttackable> { warrior1, warrior2, mage1 }; // (from the interface IAttackable)
        // List<IAttackable> fighters = new List<IAttackable> { warrior1, warrior2, mage2}; // (from the class Mage only)
        Console.WriteLine("=== All Characters Attack! ===");
        foreach (IAttackable fighter in fighters)
        {
            fighter.Attack();

            // Optional: If character can defend
            if (fighter is IDefendable defendable)
            {
                defendable.Defend();
            }
            
            Console.WriteLine();
        }
    }
}