namespace SimpleFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            store.OrderPizza("cheese");
            store.OrderPizza("veggie");
        }
    }
}
