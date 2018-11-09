using System;
using Strategy.Character;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Character!");
            var g = new Goblin();
            g.PerformAttack();
            g.PerformDefence();
            Console.ReadKey();
        }
    }
}
