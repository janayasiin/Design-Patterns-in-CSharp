using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public abstract class Pizza
    {
        public string Name { get; protected set; } = "";
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
