using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SwordAttack : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with a sword!");
        }
    }
}
