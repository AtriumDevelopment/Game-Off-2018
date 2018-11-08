using System.ComponentModel;

namespace Assets.Enemy.Modifiers
{
    class DamageModifier : EnemyModifier
    {
        private int _damageModifier;

        public DamageModifier(int duration, int modifier) : base(duration, modifier)
        {
            duration = 60;
            _damageModifier = modifier;
        }

        protected override void worker_Tick(object sender, DoWorkEventArgs e)
        {
            this.Enemy.MovementSpeed += _damageModifier;
        }
    }
}
