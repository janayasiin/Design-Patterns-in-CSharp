namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gift myGift = new TeddyBear();
            myGift = new GiftWrapping(myGift);
            myGift = new Ribbon(myGift);
            myGift= new GreetingCard(myGift);
            Console.WriteLine(myGift.GetDescription());
            Console.WriteLine(myGift.Cost());
        }
    }
}
