using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class GameCharacter
    {
        protected IAttackBehavior _attackBehavior;
        public void PerformAttack()
        {
            _attackBehavior.Attack();
        }
        public void SetAttackBehavior(IAttackBehavior attackBehavior)
        {
            this._attackBehavior = attackBehavior;
        }

    }
}
