namespace item
{
    public abstract class Item
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public int Value { get; set; }

        public Item(string name, float weight, int value)
        {
            Name = name;
            Weight = weight;
            Value = value;
        }
        public abstract void Use();
    }   
}