using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class PizzaStore 
    {
        private SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }
         public Pizza OrderPizza(string type)
        {
          Pizza pizza = factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

    }
}
