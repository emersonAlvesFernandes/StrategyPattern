using Strategy.Behaviors.Contracts;

namespace Strategy.Character
{
    public abstract class Character
    {
        protected IAttack _attack;
        protected IDefence _defence;
                
        public string Name { get; set; }
        public int LifePoints { get; set; }
        public int Level { get; set; }
        public abstract void PerformAttack();
        public abstract void PerformDefence();
    }
}