    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace StrategyPattern
    {
        public class BowAttack : IAttackBehavior
        {
            public void Attack()
            {
                Console.WriteLine("Attacking with a bow!");
            }
        }
    }
