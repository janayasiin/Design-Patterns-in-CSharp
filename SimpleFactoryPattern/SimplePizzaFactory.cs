using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new CheesePizza();
                case "veggie":
                    return new VeggiePizza();
                default:
                    throw new ArgumentException("Invalid pizza type");
            }
        }
    }
}
