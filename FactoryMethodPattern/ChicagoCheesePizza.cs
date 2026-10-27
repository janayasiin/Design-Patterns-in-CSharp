using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            Name = "Chicago Cheese Pizza";
        }

        public override void Cut()
        {
            Console.WriteLine($"Cutting {Name} into square slices");
        }
    }
}
