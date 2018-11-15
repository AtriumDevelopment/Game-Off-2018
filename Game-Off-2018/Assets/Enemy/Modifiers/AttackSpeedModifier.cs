using System.ComponentModel;

namespace Assets.Enemy.Modifiers
{ 
    class AttackSpeedModifier : EnemyModifier
    {
        public AttackSpeedModifier(int duration) : base(duration)
        {
        }

        public override void Tick(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}
