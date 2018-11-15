using System.ComponentModel;

namespace Assets.Enemy.Modifiers
{
    class SpeedModifier : EnemyModifier
    {
        public SpeedModifier(int duration) : base(duration)
        {
        }

        public override void Tick(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}
