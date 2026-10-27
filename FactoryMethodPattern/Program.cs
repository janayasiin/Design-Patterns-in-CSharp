namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            nyStore.OrderPizza("cheese");
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            chicagoStore.OrderPizza("cheese");
        }
    }
}
