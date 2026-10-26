using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class GreetingCard : GiftDecorator
    {
        private Gift wrappedGift;

        public GreetingCard(Gift wrappedGift)
        {
            this.wrappedGift = wrappedGift;
        }

        public override double Cost()
        {
            return 2 + wrappedGift.Cost();
        }

        public override string GetDescription()
        {
            return wrappedGift.GetDescription() + ", Greeting Card";
        }
    }
}
