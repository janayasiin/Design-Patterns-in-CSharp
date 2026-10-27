using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new NYCheesePizza();
            }
            throw new ArgumentException("Invalid pizza type");
        }
    }
}
