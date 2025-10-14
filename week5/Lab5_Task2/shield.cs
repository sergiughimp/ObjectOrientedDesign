using item;

namespace shield
{
    public class Shield : Item
    {

        public int Defence { get; set; }
        public Shield(string name, float weight, int value, int defence)
            : base(name, weight, value)
        {
            Defence = defence;
        }
        public override void Use()
        {
            Console.WriteLine($"{Name} is used to block {Defence} damage!");
        }
    }
}