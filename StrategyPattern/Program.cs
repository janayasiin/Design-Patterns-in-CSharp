namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacter warrior = new Warrior();
            GameCharacter archer = new Archer();
            warrior.PerformAttack(); // Output: Attacking with a sword!
            archer.PerformAttack(); // Output: Attacking with a bow!
            warrior.SetAttackBehavior(new MagicAttack());
            warrior.PerformAttack(); // Output: Attacking with magic!
        }
    }
}
