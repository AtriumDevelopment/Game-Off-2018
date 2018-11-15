using System.ComponentModel;
using System.Timers;

namespace Assets.Enemy.Modifiers
{
    public abstract class EnemyModifier 
    {
        public int Duration;

        public EnemyModifier(int duration)
        {
            Duration = duration;
        }

        public abstract void Tick(Enemy enemy);

    }
}
