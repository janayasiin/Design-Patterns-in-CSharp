using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class GiftDecorator : Gift
    {
        
            public abstract override string GetDescription();
        
    }
}
