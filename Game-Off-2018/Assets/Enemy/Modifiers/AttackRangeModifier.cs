using System.ComponentModel;

namespace Assets.Enemy.Modifiers
{
    class AttackRangeModifier : EnemyModifier
    {
        private int _attackRangeModifier;

        public AttackRangeModifier(int duration, int modifier) : base(duration, modifier)
        {
            duration = 60;
            _attackRangeModifier = modifier;
        }

        protected override void worker_Tick(object sender, DoWorkEventArgs e)
        {
            this.Enemy.MovementSpeed += _attackRangeModifier;
        }
    }
}
