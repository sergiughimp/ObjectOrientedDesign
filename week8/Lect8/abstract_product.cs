public abstract class Pizza {
    public abstract string Name { get; }
    public virtual void Prepare() => Console.WriteLine("Preparing " + Name); 
    public virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
    public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices"); 
    public virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
}