using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Gift
    {
        protected string description = "Unknown Gift";
         public virtual string GetDescription()
        {
            return description;
        }
        public abstract double Cost();
    }
}
