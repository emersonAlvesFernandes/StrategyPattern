using System;
using Strategy.Behaviors.Contracts;

namespace Strategy.Behaviors
{
    public class AttackWithKnife : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with knife!");
        }
    }
}