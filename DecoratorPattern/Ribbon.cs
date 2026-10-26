namespace DecoratorPattern
{
    public class Ribbon : GiftDecorator
    {
        private Gift wrappedGift;

        public Ribbon(Gift gift)
        {
            wrappedGift = gift;
        }

        public override double Cost()
        {
            return 3 + wrappedGift.Cost();
        }

        public override string GetDescription()
        {
            return wrappedGift.GetDescription() + ", Ribbon";
        }
    }
}