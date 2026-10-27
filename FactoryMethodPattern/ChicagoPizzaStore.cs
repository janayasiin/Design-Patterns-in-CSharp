using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoCheesePizza();
            }
            throw new ArgumentException("Invalid pizza type");
        }
    }
}
