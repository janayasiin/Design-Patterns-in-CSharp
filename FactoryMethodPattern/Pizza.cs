using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        protected string Name { get; set; } = "";
         public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }
        public virtual void Bake()
        {
            Console.WriteLine($"Baking {Name}");
        }
        public virtual void Cut()
        {
            Console.WriteLine($"Cutting {Name}");
        }
        public virtual void Box()
        {
            Console.WriteLine($"Boxing {Name}");
        }


    }
}
