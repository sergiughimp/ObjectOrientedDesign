namespace liskovPrinciple
{
    public abstract class Bird
    {
        public abstract void MakeSound();
        public virtual void Eat()
        {
            /* common behavior */
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
    public class Sparrow : Bird, IFlyable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Chirp");
        }
        public void Fly()
        {
            Console.WriteLine("Flying high!");
        }
    }
    public class Penguin : Bird
    { // No IFlyable!
        public override void MakeSound()
        {
            Console.WriteLine("Squawk");
        }
    }
}