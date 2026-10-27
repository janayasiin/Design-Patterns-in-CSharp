using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class MagicAttack : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with magic!");
        }
    }
}
