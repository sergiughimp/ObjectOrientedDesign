using item;
using interfaces;

namespace potion
{
    public class Potion : Item, ISingleUse
    {

        public int HealAmount { get; set; }
        public Potion(string name, float weight, int value, int healAmount)
            : base(name, weight, value)
        {
            HealAmount = healAmount;
        }
        public override void Use()
        {
            Console.WriteLine($"{Name} is used to heal {HealAmount} HP!");
            Consume();
        }

        public void Consume()
        {
            Console.WriteLine($"{Name} is consumed!");
        }
    }
}