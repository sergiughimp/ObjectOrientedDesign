using item;
using interfaces;

namespace weapon
{
    public class Weapon : Item, IDamage
    {

        public int Damage { get; set; }
        public Weapon(string name, float weight, int value, int damage)
            : base(name, weight, value)
        {
            Damage = damage;
        }
        public override void Use()
        {
            Console.WriteLine($"{Name} is used to attack dealing {Damage} damage!");
            DealDamage();
        }

        public void DealDamage()
        {
            Console.WriteLine($"{Name} deals {Damage} damage to the enemy!");
        }
    }
}