namespace animals {

    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class AnimalManager
    {

        // Lazy Initialization
        private static AnimalManager _instance;
        public static AnimalManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnimalManager();
                }
                return _instance;
            }
        }

        private AnimalManager() { }

        public void AddAnimal(List<Animal> animals, Animal animal)
        {
            animals.Add(animal);
        }
    }
}
