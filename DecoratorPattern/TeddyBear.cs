using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class TeddyBear : Gift
    {
        public TeddyBear()
        {
            description = "Teddy Bear";
        }

        public override double Cost()
        {
            return 19.99;
        }
    }
}
