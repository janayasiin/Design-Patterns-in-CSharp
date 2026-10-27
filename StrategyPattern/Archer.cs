using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Archer : GameCharacter
    {
        public Archer()
        {
            _attackBehavior = new BowAttack();
        }


    
    }
}
