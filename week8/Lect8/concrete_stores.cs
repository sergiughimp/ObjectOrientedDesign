public class NYPizzaStore : PizzaStore {
    protected override Pizza CreatePizza(string type) {
        if (type == "cheese") return new NYStyleCheesePizza(); 
    return null;
    }
}
public class LondonPizzaStore : PizzaStore {
    protected override Pizza CreatePizza(string type) {
                if (type == "cheese") return new LondonStyleCheesePizza(); 
        // if (type == "meat") return new LondonStyleMeatPizza(); 
    return null;
    }
}