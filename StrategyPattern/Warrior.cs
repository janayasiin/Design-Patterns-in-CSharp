using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Warrior : GameCharacter
    {
        public Warrior()
        {
            _attackBehavior = new SwordAttack();
        }


    }
}
