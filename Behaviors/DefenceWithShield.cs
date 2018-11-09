using System;
using Strategy.Behaviors.Contracts;

namespace Strategy.Behaviors
{
    public class DefenceWithShield : IDefence
    {
        public void Defence()
        {
            Console.WriteLine("Defending with Shield!");
        }
    }
}