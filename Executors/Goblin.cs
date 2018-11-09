using Strategy.Behaviors;

namespace Strategy.Character
{
    public class Goblin : Character
    {
        public Goblin()
        {
            _attack = new AttackWithKnife();
            _defence = new DefenceWithShield();
        }

        public override void PerformAttack() => _attack.Attack();
        public override void PerformDefence() => _defence.Defence();        
    }
}