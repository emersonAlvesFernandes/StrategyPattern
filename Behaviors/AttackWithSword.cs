using System;
using Strategy.Behaviors.Contracts;

namespace Strategy.Behaviors
{
    public class AttackWithSword : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with Sword!");
        }
    }
}