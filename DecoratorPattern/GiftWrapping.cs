using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class GiftWrapping : GiftDecorator
    {
        private Gift wrappedGift;
        public GiftWrapping(Gift gift)
        {
            wrappedGift = gift;
        }
      
        public override double Cost()
        {
            return 5 + wrappedGift.Cost();
        }

        public override string GetDescription()
        {
            return wrappedGift.GetDescription() + ", Gift Wrapping";
        }
    }
}

