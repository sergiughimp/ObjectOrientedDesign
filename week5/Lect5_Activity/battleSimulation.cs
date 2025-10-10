namespace battleSimulation
{
    // Interface for attackable characters
    public interface IAttackable
    {
        int AttackPower { get; set; }
        void Attack();
    }

    // Interface for defendable characters
    public interface IDefendable
    {
        int DefensePower { get; set; }
        void Defend();
    }

    // Warrior class implements both attack and defense
    public class Warrior : IAttackable, IDefendable
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int DefensePower { get; set; }

        public Warrior(string name, int attackPower, int defensePower)
        {
            Name = name;
            AttackPower = attackPower;
            DefensePower = defensePower;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks with power {AttackPower}!");
        }

        public void Defend()
        {
            Console.WriteLine($"{Name} defends with power {DefensePower}!");
        }
    }

    // Mage class implements only attack
    public class Mage : IAttackable
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }

        public Mage(string name, int attackPower)
        {
            Name = name;
            AttackPower = attackPower;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} casts a spell with power {AttackPower}!");
        }
        // Extra method (not part of the interface)
        public void Healing()
        {
            Console.WriteLine($"{Name} performs a healing spell!");
        }
    }
}