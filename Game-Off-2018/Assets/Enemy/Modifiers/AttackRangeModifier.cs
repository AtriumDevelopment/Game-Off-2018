using System.ComponentModel;

namespace Assets.Enemy.Modifiers
{
    class AttackRangeModifier : EnemyModifier
    {
        public AttackRangeModifier(int duration) : base(duration)
        {
        }

        public override void Tick(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}
