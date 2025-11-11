public class Pizza
{
    public string Size { get; set; }
    public string Crust { get; set; }
    public bool HasCheese { get; set; }
    public bool HasPepperoni { get; set; }
    public bool HasMushrooms { get; set; }
    public bool HasOlives { get; set; }
    public bool HasSausage { get; set; }
    public string SauceType { get; set; }

    public override string ToString()
    {
        return $"Pizza: {Size}, {Crust} crust, Sauce: {SauceType}, " +
               $"Cheese: {HasCheese}, Pepperoni: {HasPepperoni}, " +
               $"Mushrooms: {HasMushrooms}, Olives: {HasOlives}, Sausage: {HasSausage}";
    }
}
